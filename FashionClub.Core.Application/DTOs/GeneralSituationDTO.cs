namespace FashionClub.Core.Application.DTOs;

public class GeneralSituationDTO
{
    public List<BrandDTO>? BestBrands { get; set; }
    public List<BrandDTO>? WorstBrands { get; set; }
    public List<BrandDTO>? RetiringBrands { get; set; }
}