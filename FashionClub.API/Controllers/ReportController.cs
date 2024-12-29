using FashionClub.Core.Application.Abstractions.Services;
using FashionClub.Core.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FashionClub.API.Controllers.KlantenController;

[ApiController]
[Route("api/[controller]")]
public class ReportController(IReportService reportService) : ControllerBase
{
    [HttpGet("{klantId:int}")]
    public async Task<IActionResult> GetInitialReport(long klantId)
    {
        var report = await reportService.TryGetInitialReportAsync(klantId);
        return Ok(report);
    }

    [HttpPost]
    public async Task<IActionResult> PostCompletedReport([FromBody] ReportDto report)
    {
        var isProcessed = await reportService.ProcessFormInputDataAsync(report);
        if(!isProcessed) return new BadRequestResult();
        return Created();
    }
}