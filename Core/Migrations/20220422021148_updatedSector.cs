using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class updatedSector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddPrimaryKey(
                name: "PK_CDF_TenderSectionSub",
                table: "CDF_TenderSectionSub",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CDF_TenderSectionSub",
                table: "CDF_TenderSectionSub");
        }
    }
}
