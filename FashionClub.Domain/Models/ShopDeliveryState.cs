namespace FashionClub.Domain.Models;

public partial class ShopDeliveryState
{
    public long Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public bool IsCustomer { get; set; }
}
