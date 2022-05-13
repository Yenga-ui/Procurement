using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class updatedCore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase(
                oldCollation: "SQL_Latin1_General_CP1_CI_AS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CDF_SupplierFee",
                table: "CDF_SupplierFee",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CDF_SupplierFee",
                table: "CDF_SupplierFee");

            migrationBuilder.AlterDatabase(
                collation: "SQL_Latin1_General_CP1_CI_AS");
        }
    }
}
