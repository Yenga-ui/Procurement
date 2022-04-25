using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Procurement.Migrations
{
    public partial class pkAddedToSupplierFee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "active",
                table: "CDF_Tender",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CDF_SupplierFee",
                table: "CDF_SupplierFee",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "CDF_TenderSectionSub",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    tenderID = table.Column<int>(nullable: true),
                    tenderSectionID = table.Column<int>(nullable: true),
                    numberInput = table.Column<string>(unicode: false, nullable: true),
                    supportingDocumentation = table.Column<string>(unicode: false, nullable: true),
                    textResponse = table.Column<string>(unicode: false, nullable: true),
                    description = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_TenderSectionSub", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CDF_TenderSectionSub");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CDF_SupplierFee",
                table: "CDF_SupplierFee");

            migrationBuilder.DropColumn(
                name: "active",
                table: "CDF_Tender");
        }
    }
}
