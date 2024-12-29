namespace FashionClub.Domain.Models;

public partial class CustomerLegalHistory
{
    public long Id { get; set; }

    public long? CustomerCodeId { get; set; }

    public long CustomerId { get; set; }

    public string? VatNr { get; set; }

    public int VatCheckState { get; set; }

    public string? VatCheckDate { get; set; }

    public string? Kvk { get; set; }

    public long LegalContactId { get; set; }

    public string? RequestIdentifier { get; set; }

    public long? LegalFormId { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? VatNrSearch { get; set; }
}
