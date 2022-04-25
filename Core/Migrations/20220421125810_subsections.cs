using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class subsections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CDF_TenderSectionSub",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    tenderID = table.Column<int>(type: "int", nullable: true),
                    tenderSectionID = table.Column<int>(type: "int", nullable: true),
                    numberInput = table.Column<int>(type: "int", nullable: true),
                    supportingDocumentation = table.Column<int>(type: "int", nullable: true),
                    textResponse = table.Column<int>(type: "int", nullable: true),
                    description = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CDF_TenderSectionSub");
        }
    }
}
