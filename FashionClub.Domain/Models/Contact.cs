namespace FashionClub.Domain.Models;

public partial class Contact
{
    public long Id { get; set; }

    public long? LanguageId { get; set; }

    public string? FirstName { get; set; }

    public bool IsSupplierContact { get; set; }

    public long? AddressId { get; set; }

    public string? Remarks { get; set; }

    public bool IsHidden { get; set; }

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public long? WebUserId { get; set; }

    public string? SearchName { get; set; }

    public string? SearchName2 { get; set; }
}
