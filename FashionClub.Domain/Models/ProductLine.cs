namespace FashionClub.Domain.Models;

public partial class ProductLine
{
    public long Id { get; set; }

    public string Code { get; set; } = null!;

    public long BrandId { get; set; }

    public long LineId { get; set; }

    public long GenderId { get; set; }

    public long AgeCategoryId { get; set; }

    public long SegmentTypeId { get; set; }

    public decimal AveragePrice { get; set; }

    public int RadiusExclusivity { get; set; }

    public int FashionLevel { get; set; }

    public bool IsCompetitor { get; set; }

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
