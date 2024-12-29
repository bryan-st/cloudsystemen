using FashionClub.Core.Application.DTOs;

namespace FashionClub.Core.Application.Abstractions.Services;

public interface IReportService
{
    Task<ReportDto> TryGetInitialReportAsync(long customerId);
    
    Task<bool> ProcessFormInputDataAsync(ReportDto formInputData, CancellationToken cancellationToken = default);
}