using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace FashionClub.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder){}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgeCategories");

            migrationBuilder.DropTable(
                name: "BlockedTypes");

            migrationBuilder.DropTable(
                name: "CommercialLocations");

            migrationBuilder.DropTable(
                name: "CompetitorBrands");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "ContactTypes");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "CustomerCodes");

            migrationBuilder.DropTable(
                name: "CustomerLegalHistories");

            migrationBuilder.DropTable(
                name: "CustomerShops");

            migrationBuilder.DropTable(
                name: "CustomerTypes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "LegalForms");

            migrationBuilder.DropTable(
                name: "Lines");

            migrationBuilder.DropTable(
                name: "PaymentConditions");

            migrationBuilder.DropTable(
                name: "ProductLineDeliveries");

            migrationBuilder.DropTable(
                name: "ProductLines");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "SalesPeriods");

            migrationBuilder.DropTable(
                name: "SalesPeriodTypes");

            migrationBuilder.DropTable(
                name: "SegmentTypes");

            migrationBuilder.DropTable(
                name: "ShopCommercialLocations");

            migrationBuilder.DropTable(
                name: "ShopCompetitorBrands");

            migrationBuilder.DropTable(
                name: "ShopCompetitorProductLines");

            migrationBuilder.DropTable(
                name: "ShopContacts");

            migrationBuilder.DropTable(
                name: "ShopDeliveries");

            migrationBuilder.DropTable(
                name: "ShopDeliveryOrigins");

            migrationBuilder.DropTable(
                name: "ShopDeliveryStates");

            migrationBuilder.DropTable(
                name: "ShopDeliveryTypes");

            migrationBuilder.DropTable(
                name: "ShopGenders");

            migrationBuilder.DropTable(
                name: "ShopLines");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "ShopTypes");

            migrationBuilder.DropTable(
                name: "Spancos");

            migrationBuilder.DropTable(
                name: "VatTypes");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Users");
            
            migrationBuilder.DropSequence(
                name: "AccountingSessionNumberSequence");

            migrationBuilder.DropSequence(
                name: "AllocationNumberSequence");

            migrationBuilder.DropSequence(
                name: "B2CLinkedNumberSequence");

            migrationBuilder.DropSequence(
                name: "B2CReturnNumberSequence");

            migrationBuilder.DropSequence(
                name: "B2CUploadNumberSequence");

            migrationBuilder.DropSequence(
                name: "BackOrderNumberSequence");

            migrationBuilder.DropSequence(
                name: "BatchNumberSequence");

            migrationBuilder.DropSequence(
                name: "BleckmannInventoryNumberSequence");

            migrationBuilder.DropSequence(
                name: "BlockedDeliveryNumberSequence");

            migrationBuilder.DropSequence(
                name: "BorrowNumberSequence");

            migrationBuilder.DropSequence(
                name: "brandMIRACLESEanCodeSequence");

            migrationBuilder.DropSequence(
                name: "brandSVNTYEanCodeSequence");

            migrationBuilder.DropSequence(
                name: "brandWildwonEanCodeSequence");

            migrationBuilder.DropSequence(
                name: "BulkConfirmationNumberSequence");

            migrationBuilder.DropSequence(
                name: "BulkDeliveryNumberSequence");

            migrationBuilder.DropSequence(
                name: "BulkOrderNumberSequence");

            migrationBuilder.DropSequence(
                name: "BulkReturnIncomingNumberSequence");

            migrationBuilder.DropSequence(
                name: "BulkReturnPacklistNumberSequence");

            migrationBuilder.DropSequence(
                name: "CanceledNumberSequence");

            migrationBuilder.DropSequence(
                name: "ColorSkuSequence");

            migrationBuilder.DropSequence(
                name: "ConfirmationNumberSequence");

            migrationBuilder.DropSequence(
                name: "ConsignmentNumberSequence");

            migrationBuilder.DropSequence(
                name: "DebitCreditNoteNumberSequence");

            migrationBuilder.DropSequence(
                name: "DebitNoteNumberSequence");

            migrationBuilder.DropSequence(
                name: "DeliveryNoteNumberSequence");

            migrationBuilder.DropSequence(
                name: "DraftNumberSequence");

            migrationBuilder.DropSequence(
                name: "EanCodeSequence");

            migrationBuilder.DropSequence(
                name: "FcStoreConfirmationNumberSequence");

            migrationBuilder.DropSequence(
                name: "FcStoreDeliveryNumberSequence");

            migrationBuilder.DropSequence(
                name: "FcStoreReceptionNumberSequence");

            migrationBuilder.DropSequence(
                name: "IncomingBulkDeliveryNumberSequence");

            migrationBuilder.DropSequence(
                name: "IncomingDeliveryNumberSequence");

            migrationBuilder.DropSequence(
                name: "IncomingOccasionalNumberSequence");

            migrationBuilder.DropSequence(
                name: "IncomingPackingListNumberSequence");

            migrationBuilder.DropSequence(
                name: "InventoryNumberSequence");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201500");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201501");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201502");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201503");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201504");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201505");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201506");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201507");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201508");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201509");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201510");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201511");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201512");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201513");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201514");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201515");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201516");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201517");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201518");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201519");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201520");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201521");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201522");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201523");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201524");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201525");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201526");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201527");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201528");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201529");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201530");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201531");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201532");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201533");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201534");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201535");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201536");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201537");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201538");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201539");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201540");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201541");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201542");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201543");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201544");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201545");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201546");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201547");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201548");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201549");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201550");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201551");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201552");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201553");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201554");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201555");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201556");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201557");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201558");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201559");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201560");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201561");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201562");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201563");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201564");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201565");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201566");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201567");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201568");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201569");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201570");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201571");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201572");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201573");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201574");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201575");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201576");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201577");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201578");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201579");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201580");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201581");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201582");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201583");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201584");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201585");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201586");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201587");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201588");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201589");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201590");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201591");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201592");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201595");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201597");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201599");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201600");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201602");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201605");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201606");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201608");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201609");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201610");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201611");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201614");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201615");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201616");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201617");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201618");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201620");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201622");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201624");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201625");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201627");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201629");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201630");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201632");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201638");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201639");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201640");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201641");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201642");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201645");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201647");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201648");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201650");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201654");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201656");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201659");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201661");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201662");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201664");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201665");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201667");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201668");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201669");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201670");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201672");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201675");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201676");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201679");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201681");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201688");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201692");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201695");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201697");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201700");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201702");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201706");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201710");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201711");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201714");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201720");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201722");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201724");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201727");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201729");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201730");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201734");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201738");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201739");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201740");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201741");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201742");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201745");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201748");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201756");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201759");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201761");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201764");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201765");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201767");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201768");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201770");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201772");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201776");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201779");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201781");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201784");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201788");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201792");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201793");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201795");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201797");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201799");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201800");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2018000");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201802");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201803");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201806");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201809");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201810");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201811");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201814");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201815");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201817");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201820");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201821");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201822");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201823");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201826");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201827");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201829");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201830");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2018300");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2018301");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2018302");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201831");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201835");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201836");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201837");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201838");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201839");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201840");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201842");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201843");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201844");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201845");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2018501");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201852");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201854");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201856");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201859");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201867");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201868");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201871");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201876");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201879");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201881");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201884");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201886");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201888");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201892");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201893");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201897");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201899");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201900");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence201903");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019301");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019302");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019402");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019403");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019405");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019409");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019413");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019414");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019415");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019416");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019419");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019420");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019421");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019422");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019423");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019424");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019425");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019426");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019428");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019429");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019430");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019431");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019433");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019435");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019438");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019439");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019440");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019441");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019443");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019444");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019446");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019454");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019458");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019459");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019467");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019468");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019471");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019476");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019481");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019483");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019484");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019488");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019497");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019499");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019501");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019520");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2019530");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence202000");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence202010");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020301");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020302");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020400");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020402");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020403");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020405");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020409");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020413");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020414");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020415");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020420");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020422");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020425");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020426");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020428");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020429");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020430");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020431");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020433");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020434");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020436");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020439");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020440");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020441");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020443");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020444");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020458");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020471");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020476");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020484");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020488");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020497");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020499");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020501");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020520");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020530");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2020601");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence202100");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence202110");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021301");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021403");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021404");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021408");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021412");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021414");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021415");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021416");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021420");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021425");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021426");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021428");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021429");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021430");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021433");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021434");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021436");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021443");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021444");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021452");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021458");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021462");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021484");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021488");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021497");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021499");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021501");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence202151");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021520");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021530");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021601");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021701");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2021801");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence202200");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022301");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022403");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022404");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022405");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022407");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022408");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022410");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022412");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022413");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022415");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022416");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022419");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022420");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022426");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022429");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022430");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022434");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022443");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022444");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022452");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022458");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022462");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022465");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022475");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022476");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022484");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022488");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022497");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022499");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022501");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022520");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022530");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022601");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022701");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2022801");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence202300");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence202310");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023301");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023403");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023404");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023407");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023408");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023410");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023413");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023415");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023416");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023417");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023420");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023426");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023427");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023429");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023432");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023434");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023441");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023443");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023444");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023458");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023462");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023465");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023475");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023484");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023488");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023499");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023501");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023520");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023530");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023601");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023701");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2023801");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence202400");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024301");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024303");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024307");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024403");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024407");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024408");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024414");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024415");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024416");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024417");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024420");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024426");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024427");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024429");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024432");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024435");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024437");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024441");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024443");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024445");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024458");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024465");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024475");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024484");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024488");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024499");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024501");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024520");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024530");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024601");

            migrationBuilder.DropSequence(
                name: "InvoiceNumberSequence2024801");

            migrationBuilder.DropSequence(
                name: "MancoNumberSequence");

            migrationBuilder.DropSequence(
                name: "MiscInvoiceNumberSequence");

            migrationBuilder.DropSequence(
                name: "MiscProformaNumberSequence");

            migrationBuilder.DropSequence(
                name: "OccasionalStockNumberSequence");

            migrationBuilder.DropSequence(
                name: "OrderAtSupplierNumberSequence");

            migrationBuilder.DropSequence(
                name: "OrderNumberSequence");

            migrationBuilder.DropSequence(
                name: "PackingListNumberSequence");

            migrationBuilder.DropSequence(
                name: "PosCancelledTicketNumberSequence");

            migrationBuilder.DropSequence(
                name: "PosInvoiceNumberSequence2016492");

            migrationBuilder.DropSequence(
                name: "PosInvoiceNumberSequence2017492");

            migrationBuilder.DropSequence(
                name: "PosInvoiceNumberSequence2018492");

            migrationBuilder.DropSequence(
                name: "PosInvoiceNumberSequence2019492");

            migrationBuilder.DropSequence(
                name: "PosInvoiceNumberSequence2020492");

            migrationBuilder.DropSequence(
                name: "PosInvoiceNumberSequence2021492");

            migrationBuilder.DropSequence(
                name: "PosInvoiceNumberSequence2022492");

            migrationBuilder.DropSequence(
                name: "PosInvoiceNumberSequence2023492");

            migrationBuilder.DropSequence(
                name: "PosInvoiceNumberSequence2024492");

            migrationBuilder.DropSequence(
                name: "PosITSRequestIdNumberSequence");

            migrationBuilder.DropSequence(
                name: "PosNumberSequence");

            migrationBuilder.DropSequence(
                name: "PosParkedTicketNumberSequence");

            migrationBuilder.DropSequence(
                name: "PosReceiverNumberSequence");

            migrationBuilder.DropSequence(
                name: "PosSenderNumberSequence");

            migrationBuilder.DropSequence(
                name: "PosTransportNumberSequence");

            migrationBuilder.DropSequence(
                name: "ReorderNumberSequence");

            migrationBuilder.DropSequence(
                name: "ReturnNumberSequence");

            migrationBuilder.DropSequence(
                name: "SampleLoanNumberSequence");

            migrationBuilder.DropSequence(
                name: "SampleSelectionNumberSequence");

            migrationBuilder.DropSequence(
                name: "SampleToFC70NumberSequence");

            migrationBuilder.DropSequence(
                name: "SampleToPressNumberSequence");

            migrationBuilder.DropSequence(
                name: "SampleToReturn");

            migrationBuilder.DropSequence(
                name: "SampleToReturnNumberSequence");

            migrationBuilder.DropSequence(
                name: "ShoppingBasketNumberSequence");

            migrationBuilder.DropSequence(
                name: "StockAdjustmentNumberSequence");

            migrationBuilder.DropSequence(
                name: "StockDeliveryNumberSequence");

            migrationBuilder.DropSequence(
                name: "StockOrderNumberSequence");

            migrationBuilder.DropSequence(
                name: "StockReceiveTransferNumberSequence");

            migrationBuilder.DropSequence(
                name: "StockSendTransferNumberSequence");

            migrationBuilder.DropSequence(
                name: "SvntyWebOrderNumberSequence");

            migrationBuilder.DropSequence(
                name: "SwapBasketNumberSequence");

            migrationBuilder.DropSequence(
                name: "SwapNumberSequence");

            migrationBuilder.DropSequence(
                name: "TheftNumberSequence");

            migrationBuilder.DropSequence(
                name: "UndefinedStockNumberSequence");

            migrationBuilder.DropSequence(
                name: "WebOrderNumberSequence");
        }
    }
}
