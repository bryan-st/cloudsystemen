namespace FashionClub.Domain.Models;

public partial class City
{
    public long Id { get; set; }

    public string? PostalCode { get; set; }

    public long CountryId { get; set; }

    public long? ProvinceId { get; set; }

    public long? RegionId { get; set; }

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? SearchName { get; set; }
}
