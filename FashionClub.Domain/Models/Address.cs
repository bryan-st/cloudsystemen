using NetTopologySuite.Geometries;

namespace FashionClub.Domain.Models;

public partial class Address
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Attention { get; set; }

    public string? Street1 { get; set; }

    public string? Street2 { get; set; }

    public long? CityId { get; set; }

    public string? PostalCode { get; set; }

    public Geometry? Location { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual City? City { get; set; }

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual User UserCreated { get; set; } = null!;
}
