namespace FashionClub.Domain.Models;

public partial class CustomerShop
{
    public long Id { get; set; }

    public long ShopId { get; set; }

    public long CustomerId { get; set; }

    public bool IsActive { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
