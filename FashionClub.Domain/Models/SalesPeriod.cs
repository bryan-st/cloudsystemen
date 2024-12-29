namespace FashionClub.Domain.Models;

public partial class SalesPeriod
{
    public long Id { get; set; }

    public string ShortCode { get; set; } = null!;

    public string? Code { get; set; }

    public DateTime BeginDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal TransportCost { get; set; }

    public decimal TransportCostLimit { get; set; }

    public int InflationPercentage { get; set; }

    public long SalesPeriodTypeId { get; set; }

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public bool ShowInWebshop { get; set; }

    public DateTime? DeliveryBeginDate { get; set; }

    public DateTime? DeliveryEndDate { get; set; }

    public string? WpsCode { get; set; }

    public string? WpsYear { get; set; }

    public DateTime? LendingPeriodEndDate { get; set; }

    public bool ShopifySales { get; set; }
}
