namespace FashionClub.Domain.Models;

public partial class ProductLineDelivery
{
    public long Id { get; set; }

    public string Code { get; set; } = null!;

    public long? SalesPeriodTypeId { get; set; }

    public int SalesTime { get; set; }

    public bool IsInUse { get; set; }

    public long ProductLineId { get; set; }

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? SupplierReference { get; set; }

    public long? ProductLineDeliveryRelatedId { get; set; }
}
