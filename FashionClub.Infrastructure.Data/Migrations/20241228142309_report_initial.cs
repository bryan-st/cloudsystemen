using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FashionClub.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class report_initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ReportId",
                table: "CompetitorBrands",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ReportId",
                table: "Brands",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    TrendsAndNeeds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RerportBrands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitReportId = table.Column<long>(type: "bigint", nullable: false),
                    BrandId = table.Column<long>(type: "bigint", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RerportBrands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RerportBrands_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BrandOverviews",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<long>(type: "bigint", nullable: false),
                    SellOut = table.Column<int>(type: "int", nullable: false),
                    CommercialSupportId = table.Column<long>(type: "bigint", nullable: false),
                    ReportId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandOverviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BrandOverviews_Reports_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Reports",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConversationPartners",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLastSpoken = table.Column<bool>(type: "bit", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    ReportId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConversationPartners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConversationPartners_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConversationPartners_Reports_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Reports",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InterestingBrands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    CommercialSupportId = table.Column<long>(type: "bigint", nullable: false),
                    ReportId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestingBrands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterestingBrands_Reports_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Reports",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompetitorBrands_ReportId",
                table: "CompetitorBrands",
                column: "ReportId");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_ReportId",
                table: "Brands",
                column: "ReportId");

            migrationBuilder.CreateIndex(
                name: "IX_BrandOverviews_ReportId",
                table: "BrandOverviews",
                column: "ReportId");

            migrationBuilder.CreateIndex(
                name: "IX_ConversationPartners_CustomerId",
                table: "ConversationPartners",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ConversationPartners_ReportId",
                table: "ConversationPartners",
                column: "ReportId");

            migrationBuilder.CreateIndex(
                name: "IX_InterestingBrands_ReportId",
                table: "InterestingBrands",
                column: "ReportId");

            migrationBuilder.CreateIndex(
                name: "IX_RerportBrands_BrandId",
                table: "RerportBrands",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Reports_ReportId",
                table: "Brands",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitorBrands_Reports_ReportId",
                table: "CompetitorBrands",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Reports_ReportId",
                table: "Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_CompetitorBrands_Reports_ReportId",
                table: "CompetitorBrands");

            migrationBuilder.DropTable(
                name: "BrandOverviews");

            migrationBuilder.DropTable(
                name: "ConversationPartners");

            migrationBuilder.DropTable(
                name: "InterestingBrands");

            migrationBuilder.DropTable(
                name: "RerportBrands");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_CompetitorBrands_ReportId",
                table: "CompetitorBrands");

            migrationBuilder.DropIndex(
                name: "IX_Brands_ReportId",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "ReportId",
                table: "CompetitorBrands");

            migrationBuilder.DropColumn(
                name: "ReportId",
                table: "Brands");
        }
    }
}
