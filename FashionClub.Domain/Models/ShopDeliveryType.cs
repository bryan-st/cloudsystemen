namespace FashionClub.Domain.Models;

public partial class ShopDeliveryType
{
    public long Id { get; set; }

    public string Code { get; set; } = null!;

    public bool IsCustomer { get; set; }

    public bool ShowOnConfirmation { get; set; }

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
