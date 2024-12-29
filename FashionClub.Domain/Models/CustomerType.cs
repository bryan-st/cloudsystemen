namespace FashionClub.Domain.Models;

public partial class CustomerType
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public bool ExludeVat { get; set; }

    public bool HasToOptIn { get; set; }
}
