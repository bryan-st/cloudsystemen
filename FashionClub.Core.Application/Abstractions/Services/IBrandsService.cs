using FashionClub.Core.Application.DTOs;
using FashionClub.Domain.Models;

namespace FashionClub.Core.Application.Abstractions.Services;

public interface IBrandsService
{
     Task<List<BrandDTO>> GetBrandsByNameAsync(string name, int limit);
     Task<List<BrandDTO>> GetCompetitorsBrandsByNameAsync(string name, int limit);
}