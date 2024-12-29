namespace FashionClub.Domain.Models;

public partial class ShopDelivery
{
    public long Id { get; set; }

    public long? ShopId { get; set; }

    public long? ShopDeliveryReferenceId { get; set; }

    public long ProductLineDeliveryId { get; set; }

    public long SalesPeriodId { get; set; }

    public long ShopDeliveryStateId { get; set; }

    public long ShopDeliveryTypeId { get; set; }

    public long ShopDeliveryOriginId { get; set; }

    public decimal? BudgetAmount { get; set; }

    public int? BudgetQuantity { get; set; }

    public decimal? OrderAmount { get; set; }

    public int? OrderQuantity { get; set; }

    public string? Remarks { get; set; }

    public long? CountryId { get; set; }

    public long? Order { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public long? StockLocationId { get; set; }

    public int? BonusBudget { get; set; }

    public bool IgnoreBonusBudget { get; set; }

    public bool CanSwap { get; set; }

    public decimal? MarginPercentage { get; set; }

    public long? ShowroomId { get; set; }
}
