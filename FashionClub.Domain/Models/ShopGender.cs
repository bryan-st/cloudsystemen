namespace FashionClub.Domain.Models;

public partial class ShopGender
{
    public long Id { get; set; }

    public long GenderId { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public long? ShopId { get; set; }
}
