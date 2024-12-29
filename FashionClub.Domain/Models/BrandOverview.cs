namespace FashionClub.Domain.Models;

public class BrandOverview
{
    public long Id { get; set; }
    public long BrandId { get; set; }
    public int SellOut { get; set; }
    public long CommercialSupportId { get; set; }
}