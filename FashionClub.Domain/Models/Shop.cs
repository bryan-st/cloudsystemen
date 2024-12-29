namespace FashionClub.Domain.Models;

public partial class Shop
{
    public long Id { get; set; }

    public DateTime? OpeningDate { get; set; }

    public int? Area { get; set; }

    public int? SalesPeople { get; set; }

    public int? DisplayWindows { get; set; }

    public int? Floors { get; set; }

    public long? ShopTypeId { get; set; }

    public long? SpancoId { get; set; }

    public long? ContactId { get; set; }

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? SearchName { get; set; }

    public bool IsParallelSales { get; set; }
}
