using FashionClub.Domain.Models;

namespace FashionClub.Core.Application.DTOs;

public record BrandmixOverviewDTO(List<BrandDTO>? Brands, List<CompetitorBrandDTO>? CompetitorBrands, List<BrandOverviewDTO>? BrandOverviewDto );