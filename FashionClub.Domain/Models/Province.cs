namespace FashionClub.Domain.Models;

public partial class Province
{
    public long Id { get; set; }

    public long CountryId { get; set; }

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Code { get; set; }
}
