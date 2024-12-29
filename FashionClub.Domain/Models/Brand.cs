namespace FashionClub.Domain.Models;

public partial class Brand
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Code { get; set; }

    public long? Ean { get; set; }

    public double? MinBulkDeliveryPercentage { get; set; }

    public double? DeliveryFeePercentage { get; set; }
}
