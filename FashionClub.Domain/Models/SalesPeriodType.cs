namespace FashionClub.Domain.Models;

public partial class SalesPeriodType
{
    public long Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public DateTime? MainDeliveryStartDate { get; set; }

    public DateTime? MainDeliveryStopDate { get; set; }

    public DateTime? MainAcceptDeliveryDate { get; set; }

    public DateTime? PreDeliveryStartDate { get; set; }

    public DateTime? PreDeliveryStopDate { get; set; }

    public DateTime? PreAcceptDeliveryDate { get; set; }
}
