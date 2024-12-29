namespace FashionClub.Domain.Models;

public partial class CustomerCode
{
    public long Id { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public bool IsWpsNotified { get; set; }
}
