using FashionClub.Core.Application.Abstractions.Repositories;
using FashionClub.Core.Application.Abstractions.Services;
using FashionClub.Core.Application.DTOs;
using Microsoft.EntityFrameworkCore;

namespace FashionClub.Core.Application.Services;

internal class KlantenService(IFCRepository repository) : IKlantenService
{
    public async Task<KlantenResponseDTO> GetKlantByName(string searchName, int page, int pageSize)
    {
        var distinctIds = await GetDistinctCustomerIdsAsync(searchName);
        var totalRecords = distinctIds.Count;
        var totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);

        if (totalRecords == 0)
        {
            return new KlantenResponseDTO([], totalPages);
        }

        var pagedCustomerIds = GetPagedCustomerIds(distinctIds, page, pageSize);
        if (pagedCustomerIds.Count == 0)
        {
            return new KlantenResponseDTO([], totalPages);
        }

        var rawCustomerData = await GetRawCustomerDataAsync(pagedCustomerIds);
        var klanten = MapToKlantDTOs(rawCustomerData);

        return new KlantenResponseDTO(klanten, totalPages);
    }

    private async Task<List<long>> GetDistinctCustomerIdsAsync(string searchName)
    {
        return await repository.Customers
            .Where(customer => customer.CustomerTypeId == 1)
            .Where(customer => EF.Functions.Like(customer.Name, $"{searchName}%"))
            .OrderBy(customer => customer.Id)
            .Select(customer => customer.Id)
            .Distinct()
            .ToListAsync();
    }

    private List<long> GetPagedCustomerIds(List<long> distinctIds, int page, int pageSize)
    {
        var skipCount = (page - 1) * pageSize;
        return distinctIds
            .Skip(skipCount)
            .Take(pageSize)
            .ToList();
    }

    private async Task<List<RawCustomerData>> GetRawCustomerDataAsync(List<long> pagedCustomerIds)
    {
        var results = await (
            from customer in repository.Customers
            join contact in repository.Contacts on customer.Name equals contact.Name
            join address in repository.Addresses.Include(a => a.City) on contact.AddressId equals address.Id
            where pagedCustomerIds.Contains(customer.Id)
            select new RawCustomerData(
                customer.Id,
                customer.Name,
                address.City.Name,
                address.Street1 ?? address.Street2,
                address.PostalCode
            )
        ).ToListAsync();

        return results;
    }

private List<KlantDTO> MapToKlantDTOs(List<RawCustomerData> rawData)
{
    return rawData
        .GroupBy(rawCustomerData => rawCustomerData.CustomerId)
        .Select(groupedRawData =>
        {
            var first = groupedRawData.First();
            return new KlantDTO(
                first.CustomerId,
                first.CustomerName,
                new(
                    first.CityName,
                    first.Street,
                    first.PostalCode
                )
            );
        })
        .ToList();
    }

    public async Task<List<ShopDTO>> GetKlantShopsById(long klantId)
    {
        //TODO: Add Address to shop [figuring out the relations between shop and address]
        throw new NotImplementedException();
    }
    
    private record RawCustomerData(
        long CustomerId,
        string CustomerName,
        string CityName,
        string Street,
        string PostalCode
    );
}