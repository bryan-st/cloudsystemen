using FashionClub.Core.Application.Abstractions.Repositories;
using FashionClub.Core.Application.Abstractions.Services;
using FashionClub.Core.Application.DTOs;
using FashionClub.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FashionClub.Core.Application.Services;

public class ReportService(IFCRepository repository) : IReportService
{
    public async Task<ReportDto> TryGetInitialReportAsync(long customerId)
    {
        var previousReport = repository.Reports
            .Include(r => r.Brands)
            .Include(r => r.CompetitorBrands)
            .OrderByDescending(r => r.Date)
            .FirstOrDefault(r => r.CustomerId == customerId);

        if (previousReport == null) return new ReportDto() { KlantId = customerId };
        previousReport.ConversationPartners = repository.ConversationPartners
            .Where(cp => cp.CustomerId == customerId)
            .ToList();

        return await MapToReportDto(previousReport);

    }


    public async Task<bool> ProcessFormInputDataAsync(ReportDto formInputData, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(formInputData);

        var report = MapToReport(formInputData);
        
        repository.Reports.Add(report);

        await repository.SaveChangesAsync(cancellationToken);

        return true;
    }
    
    private List<ConversationPartnerDTO> MapToConversationPartnerDTO(List<ConversationPartner> partners)
    {
        return partners.Select(partner => new ConversationPartnerDTO
        {
            Id = partner.Id,
            FirstName = partner.FirstName,
            LastName = partner.LastName,
            IsLastSpoken = partner.IsLastSpoken,
        }).ToList();
    }

    private Report MapToReport(ReportDto dto)
    {
        var existingPartnerNames = repository.ConversationPartners
            .Where(c => c.CustomerId == dto.KlantId)
            .Select(p => new { p.FirstName, p.LastName })
            .ToHashSet();

        var brandIds = dto.BrandMixOverview.Brands.Select(dtoBrand => dtoBrand.Id).ToList();
        var brands = repository.Brands
            .Where(b => brandIds.Contains(b.Id))
            .ToList();

        var competitorBrandIds = dto.BrandMixOverview.CompetitorBrands.Select(dtoCompetitor => dtoCompetitor.Id).ToList();
        var competitorBrands = repository.CompetitorBrands
            .Where(cb => competitorBrandIds.Contains(cb.Id))
            .ToList();

        
        var partners = dto.ConversationPartners
            .Where(p => !existingPartnerNames.Contains(new { p.FirstName, p.LastName }))
            .Select(p => new ConversationPartner
            {
                FirstName = p.FirstName,
                LastName = p.LastName,
                IsLastSpoken = p.IsLastSpoken,
                CustomerId = dto.KlantId
            })
            .ToList();

        return new Report()
        {
            CustomerId = dto.KlantId,
            Date = DateOnly.FromDateTime(DateTime.UtcNow),
            Reason = dto.Reason,
            Feedback = dto.Feedback,
            TrendsAndNeeds = dto.TrendsRequirements,
            Brands = brands,
            CompetitorBrands = competitorBrands,
            ConversationPartners = partners,
        };
    }
    
    private async Task<ReportDto> MapToReportDto(Report report)
    {
        BrandmixOverviewDTO? brandmixDto = null;
        var customerData = await GetCustomerData(report.CustomerId);
        if (report.Brands != null && report.Brands.Any())
        {
            var brands = report.Brands
                .Select(b => new BrandDTO(b.Id, b.Name))
                .ToList();

            var competitorBrands = report.CompetitorBrands
                .Select(b => new CompetitorBrandDTO(b.Id, b.Name))
                .ToList();

            brandmixDto = new BrandmixOverviewDTO(brands, competitorBrands, null);
        }

        return new ReportDto()
        {
            KlantId = customerData.Klant.Id,
            ConversationPartners = MapToConversationPartnerDTO(report.ConversationPartners),
            Reason = report.Reason,
            Feedback = report.Feedback,
            TrendsRequirements = report.Feedback,
            BrandMixOverview = brandmixDto
        };
    }


    private async Task<CustomerDataDTO> GetCustomerData(long customerId)
    {
        var customerData = await repository.Customers
            .Where(customer => customer.Id == customerId)
            .Select(customer => new
             CustomerDataDTO()
             {
                 
                Klant = customer,
                Contact = repository.Contacts.FirstOrDefault(c => c.Name == customer.Name),
                Address = repository.Addresses
                    .Include(a => a.City)
                    .FirstOrDefault(a => a.Id == repository.Contacts
                        .Where(c => c.Name == customer.Name)
                        .Select(c => c.AddressId)
                        .FirstOrDefault()),
            })
            .FirstOrDefaultAsync();

        if (customerData == null) throw new Exception($"Customer with Id {customerId} not found.");
        if (customerData.Contact == null) throw new Exception($"There is no contact for Customer {customerData.Klant.Name}");
        if (customerData.Address == null) throw new Exception($"There is no address for Customer {customerData.Klant.Name}");
        
        return customerData;
    }
    
}