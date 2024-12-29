namespace FashionClub.Domain.Models;

public partial class Language
{
    public long Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public bool DocumentSupported { get; set; }

    public bool DocumentDefault { get; set; }
}
