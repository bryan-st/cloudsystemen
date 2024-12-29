﻿namespace FashionClub.Domain.Models;

public partial class Customer
{
    public long Id { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public decimal Discount { get; set; }

    public long? DeliveryMethodId { get; set; }

    public long? UpfrontPaymentId { get; set; }

    public long? PaymentConditionId { get; set; }

    public long? CurrencyId { get; set; }

    public long? BlockedTypeId { get; set; }

    public DateTime? BlockedDate { get; set; }

    public string? BlockedReason { get; set; }

    public string? Remarks { get; set; }

    public string? AccountNr { get; set; }

    public string? Iban { get; set; }

    public string? Bic { get; set; }

    public string? BankName { get; set; }

    public long? BankCityId { get; set; }

    public long? VatTypeId { get; set; }

    public long? KeyAccountManagerId { get; set; }

    public long DeliveryLocationTypeId { get; set; }

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public bool IsKeyAccount { get; set; }

    public string? SearchName { get; set; }

    public bool IsPosCustomer { get; set; }

    public bool Top50 { get; set; }

    public bool Dd { get; set; }

    public long? CustomerTypeId { get; set; }

    public int AttendedCollectionSale { get; set; }

    public bool IsPrivate { get; set; }

    public string? CollectionSaleCustomerCode { get; set; }

    public decimal? MaximumBudget { get; set; }

    public bool IgnoreAutomaticOverrule { get; set; }

    public bool IsDeleted { get; set; }

    public long? AgentId { get; set; }

    public bool CanAlwaysSwap { get; set; }

    public string? GlobalLocationNumber { get; set; }

    public bool AgreeToUseTheirData { get; set; }

    public long? CustomerLoyaltyId { get; set; }

    public DateTime? AnniversaryDay { get; set; }

    public long? AccountingCodeId { get; set; }

    public bool IsKeyClient { get; set; }

    public long? GenderId { get; set; }

    public string? MiscAccountingCode { get; set; }

    public DateTime? DateUpdated { get; set; }

    public bool IgnoreInReporting { get; set; }
}
