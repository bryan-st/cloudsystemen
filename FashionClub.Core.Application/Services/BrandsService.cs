using FashionClub.Core.Application.Abstractions.Repositories;
using FashionClub.Core.Application.Abstractions.Services;
using FashionClub.Core.Application.DTOs;
using Microsoft.EntityFrameworkCore;

namespace FashionClub.Core.Application.Services;

public class BrandsService(IFCRepository repository) : IBrandsService
{
    public async Task<List<BrandDTO>> GetBrandsByNameAsync(string name, int limit)
    {
        //TODO: Add SalesRepresentatives Id's (See BrandDTO)
        
        return await repository.Brands
            .Where(brand => EF.Functions.Like(brand.Name, $"{name}%"))
            .Select(brand => new BrandDTO(brand.Id, brand.Name))
            .Take(limit)
            .ToListAsync();

    }

    public async Task<List<BrandDTO>> GetCompetitorsBrandsByNameAsync(string name, int limit)
    {
        return await repository.CompetitorBrands
            .Where(brand => EF.Functions.Like(brand.Name, $"{name}%"))
            .Select(brand => new BrandDTO(brand.Id, brand.Name))
            .Take(limit)
            .ToListAsync();
    }
}