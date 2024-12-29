namespace FashionClub.Domain.Models;

public partial class VatType
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public bool IsTaxLevy { get; set; }

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
