namespace FashionClub.Domain.Models;

public partial class Currency
{
    public long Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Sign { get; set; }

    public bool IsDefault { get; set; }

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
