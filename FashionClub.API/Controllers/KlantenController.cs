using FashionClub.Core.Application.Abstractions.Services;
using Microsoft.AspNetCore.Mvc;

namespace FashionClub.API.Controllers.KlantenController;

[ApiController]
[Route("api/[controller]")]
public class KlantenController(IKlantenService klantenService)  : ControllerBase
{
    [HttpGet("{searchName:alpha}/{page:int}")]
    public async Task<IActionResult> GetKlanten(string searchName, int page = 1)
    {
        var responseDto = await klantenService.GetKlantByName(searchName, page, 10);
        if (responseDto.Klanten.Count == 0) return new NotFoundResult(); 
        return Ok(responseDto);
    }

    [HttpGet("{id:int}/shops")]
    public async Task<IActionResult> GetKlantById(int id)
    {
        var klantShops = await klantenService.GetKlantShopsById(id);
        return Ok(klantShops);
    }
}