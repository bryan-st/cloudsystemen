using FashionClub.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FashionClub.Infrastructure.Data.Persistence;

public partial class FashionClubDbContext : DbContext
{
    public FashionClubDbContext()
    {
    }

    public FashionClubDbContext(DbContextOptions<FashionClubDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AgeCategory> AgeCategories { get; set; }

    public virtual DbSet<BlockedType> BlockedTypes { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<CommercialLocation> CommercialLocations { get; set; }

    public virtual DbSet<CompetitorBrand> CompetitorBrands { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<ContactType> ContactTypes { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerCode> CustomerCodes { get; set; }

    public virtual DbSet<CustomerLegalHistory> CustomerLegalHistories { get; set; }

    public virtual DbSet<CustomerShop> CustomerShops { get; set; }

    public virtual DbSet<CustomerType> CustomerTypes { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LegalForm> LegalForms { get; set; }

    public virtual DbSet<Line> Lines { get; set; }

    public virtual DbSet<PaymentCondition> PaymentConditions { get; set; }

    public virtual DbSet<ProductLine> ProductLines { get; set; }

    public virtual DbSet<ProductLineDelivery> ProductLineDeliveries { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<SalesPeriod> SalesPeriods { get; set; }

    public virtual DbSet<SalesPeriodType> SalesPeriodTypes { get; set; }

    public virtual DbSet<SegmentType> SegmentTypes { get; set; }

    public virtual DbSet<Shop> Shops { get; set; }

    public virtual DbSet<ShopCommercialLocation> ShopCommercialLocations { get; set; }

    public virtual DbSet<ShopCompetitorBrand> ShopCompetitorBrands { get; set; }

    public virtual DbSet<ShopCompetitorProductLine> ShopCompetitorProductLines { get; set; }

    public virtual DbSet<ShopContact> ShopContacts { get; set; }

    public virtual DbSet<ShopDelivery> ShopDeliveries { get; set; }

    public virtual DbSet<ShopDeliveryOrigin> ShopDeliveryOrigins { get; set; }

    public virtual DbSet<ShopDeliveryState> ShopDeliveryStates { get; set; }

    public virtual DbSet<ShopDeliveryType> ShopDeliveryTypes { get; set; }

    public virtual DbSet<ShopGender> ShopGenders { get; set; }

    public virtual DbSet<ShopLine> ShopLines { get; set; }

    public virtual DbSet<ShopType> ShopTypes { get; set; }

    public virtual DbSet<Spanco> Spancos { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<VatType> VatTypes { get; set; }
    
    public virtual DbSet<Report> Reports { get; set; }
    
    public virtual DbSet<BrandOverview> BrandOverviews { get; set; }
    
    public virtual DbSet<ReportBrand> RerportBrands { get; set; }
    
    public virtual DbSet<InterestingBrand> InterestingBrands { get; set; }
    
    public virtual DbSet<ConversationPartner> ConversationPartners { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Addresses");

            entity.Property(e => e.Attention).HasMaxLength(100);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PostalCode).HasMaxLength(50);
            entity.Property(e => e.Street1).HasMaxLength(100);
            entity.Property(e => e.Street2).HasMaxLength(100);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<AgeCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AgeCategories");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<BlockedType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.BlockedTypes");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Brands");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Ean).HasColumnName("EAN");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Cities");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.PostalCode).HasMaxLength(50);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<CommercialLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CommercialLocations");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<CompetitorBrand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CompetitorBrands");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Contacts");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ContactType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ContactTypes");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Countries");

            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Currencies");

            entity.Property(e => e.Code).HasMaxLength(3);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Customers");

            entity.Property(e => e.AccountNr).HasMaxLength(50);
            entity.Property(e => e.AnniversaryDay).HasColumnType("datetime");
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.Bic).HasMaxLength(50);
            entity.Property(e => e.BlockedDate).HasColumnType("datetime");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateUpdated).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Iban).HasMaxLength(50);
            entity.Property(e => e.MaximumBudget).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MiscAccountingCode).HasMaxLength(6);
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.SearchName).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<CustomerCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CustomerCodes");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<CustomerLegalHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CustomerLegalHistories");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Kvk).HasMaxLength(25);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.VatNr).HasMaxLength(25);
        });

        modelBuilder.Entity<CustomerShop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CustomerShops");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<CustomerType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CustomerTypes");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Employees");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.RecurringAppointmentId).HasColumnName("RecurringAppointment_Id");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Genders");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Languages");

            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<LegalForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.LegalForms");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Line>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Lines");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<PaymentCondition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PaymentConditions");

            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ProductLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ProductLines");

            entity.Property(e => e.AveragePrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ProductLineDelivery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ProductLineDeliveries");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Province>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Provinces");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Regions");

            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<SalesPeriod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.SalesPeriods");

            entity.Property(e => e.BeginDate).HasColumnType("datetime");
            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DeliveryBeginDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryEndDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.LendingPeriodEndDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.ShortCode).HasMaxLength(10);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.TransportCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransportCostLimit).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<SalesPeriodType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.SalesPeriodTypes");

            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.MainAcceptDeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.MainDeliveryStartDate).HasColumnType("datetime");
            entity.Property(e => e.MainDeliveryStopDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.PreAcceptDeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.PreDeliveryStartDate).HasColumnType("datetime");
            entity.Property(e => e.PreDeliveryStopDate).HasColumnType("datetime");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<SegmentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.SegmentTypes");

            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Shop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Shops");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.OpeningDate).HasColumnType("datetime");
            entity.Property(e => e.SearchName).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ShopCommercialLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ShopCommercialLocations");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.ShopId).HasColumnName("Shop_Id");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ShopCompetitorBrand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ShopCompetitorBrands");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.ShopId).HasColumnName("Shop_Id");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ShopCompetitorProductLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ShopCompetitorProductLines");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.ShopId).HasColumnName("Shop_Id");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ShopContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ShopContacts");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.ShopId).HasColumnName("Shop_Id");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ShopDelivery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ShopDeliveries");

            entity.Property(e => e.BudgetAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.MarginPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ShopDeliveryOrigin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ShopDeliveryOrigins");

            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ShopDeliveryState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ShopDeliveryStates");

            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ShopDeliveryType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ShopDeliveryTypes");

            entity.Property(e => e.Code).HasMaxLength(15);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ShopGender>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ShopGenders");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.ShopId).HasColumnName("Shop_Id");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ShopLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ShopLines");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.ShopId).HasColumnName("Shop_Id");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ShopType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ShopTypes");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Spanco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Spancos");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Users");

            entity.Property(e => e.Login).HasMaxLength(200);
        });

        modelBuilder.Entity<VatType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.VatTypes");

            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });
        modelBuilder.HasSequence("AccountingSessionNumberSequence")
            .StartsAt(1514L)
            .HasMin(0L);
        modelBuilder.HasSequence("AllocationNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("B2CLinkedNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("B2CReturnNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("B2CUploadNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("BackOrderNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("BatchNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("BleckmannInventoryNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("BlockedDeliveryNumberSequence")
            .StartsAt(10893L)
            .HasMin(0L);
        modelBuilder.HasSequence("BorrowNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("brandMIRACLESEanCodeSequence")
            .StartsAt(540084680000L)
            .HasMin(540084680000L)
            .HasMax(540084690000L);
        modelBuilder.HasSequence("brandSVNTYEanCodeSequence")
            .StartsAt(540084601712L)
            .HasMin(540084000000L);
        modelBuilder.HasSequence("brandWildwonEanCodeSequence")
            .StartsAt(540084690228L)
            .HasMin(540084690000L)
            .HasMax(540084700000L);
        modelBuilder.HasSequence("BulkConfirmationNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("BulkDeliveryNumberSequence")
            .StartsAt(81L)
            .HasMin(0L);
        modelBuilder.HasSequence("BulkOrderNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("BulkReturnIncomingNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("BulkReturnPacklistNumberSequence")
            .StartsAt(170L)
            .HasMin(0L);
        modelBuilder.HasSequence("CanceledNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("ColorSkuSequence").StartsAt(200000L);
        modelBuilder.HasSequence("ConfirmationNumberSequence")
            .StartsAt(42661L)
            .HasMin(0L);
        modelBuilder.HasSequence("ConsignmentNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("DebitCreditNoteNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("DebitNoteNumberSequence")
            .StartsAt(55L)
            .HasMin(0L);
        modelBuilder.HasSequence("DeliveryNoteNumberSequence")
            .StartsAt(55122L)
            .HasMin(0L);
        modelBuilder.HasSequence("DraftNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("EanCodeSequence")
            .StartsAt(8382416L)
            .HasMin(0L);
        modelBuilder.HasSequence("FcStoreConfirmationNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("FcStoreDeliveryNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("FcStoreReceptionNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("IncomingBulkDeliveryNumberSequence")
            .StartsAt(41L)
            .HasMin(0L);
        modelBuilder.HasSequence("IncomingDeliveryNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("IncomingOccasionalNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("IncomingPackingListNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("InventoryNumberSequence")
            .StartsAt(1199L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201500").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201501").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201502")
            .StartsAt(9123L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201503")
            .StartsAt(46L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201504").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201505")
            .StartsAt(286L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201506")
            .StartsAt(317L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201507").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201508")
            .StartsAt(38L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201509").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201510").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201511").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201512").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201513")
            .StartsAt(7L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201514").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201515").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201516")
            .StartsAt(8L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201517")
            .StartsAt(43L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201518")
            .StartsAt(129L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201519").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201520")
            .StartsAt(161L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201521").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201522").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201523").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201524").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201525").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201526")
            .StartsAt(5L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201527").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201528")
            .StartsAt(2L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201529")
            .StartsAt(196L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201530").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201531").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201532").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201533").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201534").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201535").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201536")
            .StartsAt(2L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201537")
            .StartsAt(2L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201538").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201539")
            .StartsAt(268L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201540")
            .StartsAt(451L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201541")
            .StartsAt(385L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201542").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201543")
            .StartsAt(8L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201544")
            .StartsAt(28L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201545")
            .StartsAt(251L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201546")
            .StartsAt(2L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201547").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201548").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201549")
            .StartsAt(12L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201550").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201551").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201552").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201553").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201554").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201555").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201556").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201557")
            .StartsAt(3L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201558").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201559")
            .StartsAt(386L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201560").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201561").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201562").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201563").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201564").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201565")
            .StartsAt(26L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201566").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201567").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201568").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201569")
            .StartsAt(17L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201570")
            .StartsAt(123L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201571").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201572").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201573").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201574").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201575")
            .StartsAt(82L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201576")
            .StartsAt(223L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201577").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201578")
            .StartsAt(3L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201579")
            .StartsAt(58L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201580").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201581")
            .StartsAt(437L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201582").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201583").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201584").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201585").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201586").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201587")
            .StartsAt(33L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201588")
            .StartsAt(408L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201589")
            .StartsAt(32L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201590").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201591").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201592")
            .StartsAt(2L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201595")
            .StartsAt(10757L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201597")
            .StartsAt(313L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201599").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201600")
            .StartsAt(32L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201602")
            .StartsAt(7478L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201605").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201606")
            .StartsAt(433L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201608").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201609").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201610").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201611").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201614").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201615").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201616").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201617").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201618").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201620").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201622")
            .StartsAt(9L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201624").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201625").StartsAt(9L);
        modelBuilder.HasSequence("InvoiceNumberSequence201627").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201629").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201630").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201632").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201638")
            .StartsAt(10L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201639")
            .StartsAt(18L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201640")
            .StartsAt(703L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201641").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201642").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201645").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201647").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201648").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201650").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201654").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201656")
            .StartsAt(12L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201659").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201661").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201662").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201664").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201665").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201667")
            .StartsAt(1139L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201668").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201669").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201670")
            .StartsAt(11L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201672").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201675").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201676").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201679").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201681")
            .StartsAt(23L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201688")
            .StartsAt(618L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201692")
            .StartsAt(7L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201695").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201697")
            .StartsAt(409L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201700").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201702")
            .StartsAt(6653L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201706")
            .StartsAt(2771L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201710").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201711").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201714").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201720").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201722").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201724").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201727").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201729").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201730").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201734").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201738").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201739").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201740")
            .StartsAt(1010L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201741").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201742").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201745")
            .StartsAt(28L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201748").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201756").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201759").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201761").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201764").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201765").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201767")
            .StartsAt(1032L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201768").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201770").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201772")
            .StartsAt(181L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201776").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201779").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201781").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201784").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201788").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201792").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201793")
            .StartsAt(3L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201795").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201797")
            .StartsAt(1712L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201799")
            .StartsAt(36L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201800").StartsAt(290L);
        modelBuilder.HasSequence("InvoiceNumberSequence2018000").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201802")
            .StartsAt(5871L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201803").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201806").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201809").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201810").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201811").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201814").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201815").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201817").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201820").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201821")
            .StartsAt(137L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201822").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201823").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201826").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201827").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201829").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201830").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2018300").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2018301").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2018302").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201831").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201835").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201836").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201837").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201838").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201839").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201840").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201842").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201843")
            .StartsAt(5L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201844")
            .StartsAt(8L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201845").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2018501").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201852")
            .StartsAt(3L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201854").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201856").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201859").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201867").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201868").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201871").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201876").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201879").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201881").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201884").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201886").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201888")
            .StartsAt(228L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201892").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201893")
            .StartsAt(12L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201897").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201899")
            .StartsAt(31L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201900")
            .StartsAt(123L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence201903").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019301")
            .StartsAt(5693L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019302").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019402")
            .StartsAt(1393L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019403").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019405").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019409").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019413").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019414").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019415").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019416").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019419").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019420").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019421").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019422").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019423").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019424").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019425").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019426").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019428").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019429").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019430").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019431").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019433").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019435").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019438").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019439").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019440").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019441").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019443")
            .StartsAt(5L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019444").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019446").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019454").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019458").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019459").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019467").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019468").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019471").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019476").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019481").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019483").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019484").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019488").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019497").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019499")
            .StartsAt(16L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019501")
            .StartsAt(1695L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019520").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2019530").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence202000").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence202010").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020301")
            .StartsAt(6271L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020302")
            .StartsAt(5L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020400").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020402").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020403").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020405").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020409").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020413").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020414").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020415")
            .StartsAt(418L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020420").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020422").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020425").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020426").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020428").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020429").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020430").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020431").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020433").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020434").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020436").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020439").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020440").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020441").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020443")
            .StartsAt(22L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020444").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020458").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020471").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020476").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020484").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020488")
            .StartsAt(628L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020497").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020499").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020501")
            .StartsAt(1697L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020520").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020530").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2020601")
            .StartsAt(875L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence202100").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence202110").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021301")
            .StartsAt(317L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021403").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021404").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021408").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021412").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021414").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021415").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021416").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021420").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021425").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021426").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021428").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021429").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021430").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021433").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021434").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021436").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021443").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021444").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021452").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021458").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021462").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021484").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021488").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021497").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021499").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021501")
            .StartsAt(40L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence202151").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021520").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021530").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021601")
            .StartsAt(56L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021701")
            .StartsAt(40L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2021801").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence202200")
            .StartsAt(56L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022301")
            .StartsAt(3902L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022403").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022404").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022405").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022407").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022408").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022410").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022412").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022413").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022415").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022416").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022419").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022420").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022426").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022429").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022430").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022434").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022443").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022444").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022452").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022458").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022462").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022465").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022475").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022476").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022484").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022488").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022497").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022499").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022501")
            .StartsAt(191L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022520").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022530").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022601")
            .StartsAt(1553L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022701").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2022801").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence202300").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence202310").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023301")
            .StartsAt(3749L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023403").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023404").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023407").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023408").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023410").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023413").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023415").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023416")
            .StartsAt(607L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023417").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023420").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023426").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023427").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023429").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023432").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023434").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023441").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023443").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023444").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023458").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023462").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023465").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023475").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023484").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023488").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023499").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023501").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023520").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023530").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023601").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023701").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2023801").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence202400")
            .StartsAt(121L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024301")
            .StartsAt(486L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024303")
            .StartsAt(73L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024307").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024403")
            .StartsAt(985L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024407")
            .StartsAt(181L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024408").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024414").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024415").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024416").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024417").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024420").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024426").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024427").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024429").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024432").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024435")
            .StartsAt(30L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024437").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024441").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024443").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024445").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024458").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024465").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024475").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024484").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024488").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024499")
            .StartsAt(2L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024501")
            .StartsAt(459L)
            .HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024520").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024530").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024601").HasMin(0L);
        modelBuilder.HasSequence("InvoiceNumberSequence2024801").HasMin(0L);
        modelBuilder.HasSequence("MancoNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("MiscInvoiceNumberSequence").StartsAt(80750L);
        modelBuilder.HasSequence("MiscProformaNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("OccasionalStockNumberSequence")
            .StartsAt(317L)
            .HasMin(0L);
        modelBuilder.HasSequence("OrderAtSupplierNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("OrderNumberSequence")
            .StartsAt(6L)
            .HasMin(0L);
        modelBuilder.HasSequence("PackingListNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("PosCancelledTicketNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("PosInvoiceNumberSequence2016492")
            .StartsAt(3614L)
            .HasMin(0L);
        modelBuilder.HasSequence("PosInvoiceNumberSequence2017492")
            .StartsAt(1378L)
            .HasMin(0L);
        modelBuilder.HasSequence("PosInvoiceNumberSequence2018492")
            .StartsAt(2459L)
            .HasMin(0L);
        modelBuilder.HasSequence("PosInvoiceNumberSequence2019492")
            .StartsAt(1789L)
            .HasMin(0L);
        modelBuilder.HasSequence("PosInvoiceNumberSequence2020492")
            .StartsAt(105L)
            .HasMin(0L);
        modelBuilder.HasSequence("PosInvoiceNumberSequence2021492").HasMin(0L);
        modelBuilder.HasSequence("PosInvoiceNumberSequence2022492").HasMin(0L);
        modelBuilder.HasSequence("PosInvoiceNumberSequence2023492")
            .StartsAt(789L)
            .HasMin(0L);
        modelBuilder.HasSequence("PosInvoiceNumberSequence2024492").HasMin(0L);
        modelBuilder.HasSequence("PosITSRequestIdNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("PosNumberSequence")
            .StartsAt(7348L)
            .HasMin(0L);
        modelBuilder.HasSequence("PosParkedTicketNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("PosReceiverNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("PosSenderNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("PosTransportNumberSequence")
            .StartsAt(20L)
            .HasMin(0L);
        modelBuilder.HasSequence("ReorderNumberSequence")
            .StartsAt(2239L)
            .HasMin(0L);
        modelBuilder.HasSequence("ReturnNumberSequence")
            .StartsAt(34447L)
            .HasMin(0L);
        modelBuilder.HasSequence("SampleLoanNumberSequence")
            .StartsAt(888L)
            .HasMin(0L);
        modelBuilder.HasSequence("SampleSelectionNumberSequence")
            .StartsAt(952L)
            .HasMin(0L);
        modelBuilder.HasSequence("SampleToFC70NumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("SampleToPressNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("SampleToReturn")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("SampleToReturnNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("ShoppingBasketNumberSequence").HasMin(0L);
        modelBuilder.HasSequence("StockAdjustmentNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("StockDeliveryNumberSequence")
            .StartsAt(362L)
            .HasMin(0L);
        modelBuilder.HasSequence("StockOrderNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("StockReceiveTransferNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("StockSendTransferNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("SvntyWebOrderNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("SwapBasketNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("SwapNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("TheftNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("UndefinedStockNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);
        modelBuilder.HasSequence("WebOrderNumberSequence")
            .StartsAt(0L)
            .HasMin(0L);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
