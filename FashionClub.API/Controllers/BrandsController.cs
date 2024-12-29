using FashionClub.Core.Application.Abstractions.Services;
using Microsoft.AspNetCore.Mvc;

namespace FashionClub.API.Controllers.KlantenController;

[ApiController]
[Route("api/[controller]")]
public class BrandsController(IBrandsService brandsService) : ControllerBase
{
    [HttpGet("fc70/{name:alpha}")]
    public async Task<IActionResult> GetBrandsByName(string name, int limit = 10)
    {
        var brands = await brandsService.GetBrandsByNameAsync(name, limit);
        if (!brands.Any()) return NotFound();
        return Ok(brands);
    }

    [HttpGet("competitorbrands/{name:alpha}")]
    public async Task<IActionResult> GetBrandsByNameCompetitorBrands(string name, int limit = 10)
    {
        var competitorsBrands = await brandsService.GetCompetitorsBrandsByNameAsync(name, limit);
        if (!competitorsBrands.Any()) return NotFound();
        return Ok(competitorsBrands);
    }
}