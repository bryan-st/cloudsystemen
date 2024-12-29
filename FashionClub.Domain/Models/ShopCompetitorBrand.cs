namespace FashionClub.Domain.Models;

public partial class ShopCompetitorBrand
{
    public long Id { get; set; }

    public long CompetitorBrandId { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public long? ShopId { get; set; }
}
