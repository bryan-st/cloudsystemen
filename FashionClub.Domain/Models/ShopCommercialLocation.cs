namespace FashionClub.Domain.Models;

public partial class ShopCommercialLocation
{
    public long Id { get; set; }

    public long CommercialLocationId { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public long? ShopId { get; set; }
}
