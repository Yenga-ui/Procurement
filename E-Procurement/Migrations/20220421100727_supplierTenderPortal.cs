using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Procurement.Migrations
{
    public partial class supplierTenderPortal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "paid",
                table: "SupplierRegistation",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tenderID",
                table: "Cdf_TenderSection",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "amount",
                table: "CDF_Tender",
                type: "decimal(18, 0)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cdf_Supplier_ResDocuments",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(unicode: false, nullable: true),
                    type = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    path = table.Column<string>(unicode: false, nullable: true),
                    section_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cdf_Supplier_ResDocuments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cdf_Supplier_Response",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tender_id = table.Column<int>(nullable: false),
                    section_id = table.Column<int>(nullable: false),
                    text_response = table.Column<string>(type: "text", nullable: true),
                    supplier_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cdf_Supplier_Response", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_SupplierFee",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierFee = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    active = table.Column<int>(nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CDF_SupplierTenderPayment",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    supplierCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    tenderCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    paid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_SupplierTenderPayment", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cdf_Supplier_ResDocuments");

            migrationBuilder.DropTable(
                name: "Cdf_Supplier_Response");

            migrationBuilder.DropTable(
                name: "CDF_SupplierFee");

            migrationBuilder.DropTable(
                name: "CDF_SupplierTenderPayment");

            migrationBuilder.DropColumn(
                name: "paid",
                table: "SupplierRegistation");

            migrationBuilder.DropColumn(
                name: "tenderID",
                table: "Cdf_TenderSection");

            migrationBuilder.DropColumn(
                name: "amount",
                table: "CDF_Tender");
        }
    }
}
