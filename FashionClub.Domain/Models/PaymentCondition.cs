namespace FashionClub.Domain.Models;

public partial class PaymentCondition
{
    public long Id { get; set; }

    public string Code { get; set; } = null!;

    public int DueDateCalculator { get; set; }

    public bool Fdi { get; set; }

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? NameFr { get; set; }

    public string? NameEn { get; set; }

    public bool IsConsignment { get; set; }
}
