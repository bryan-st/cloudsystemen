namespace FashionClub.Domain.Models;

public partial class Country
{
    public long Id { get; set; }

    public string Code { get; set; } = null!;

    public long CurrencyId { get; set; }

    public long PaymentConditionId { get; set; }

    public long? VatTypeId { get; set; }

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
