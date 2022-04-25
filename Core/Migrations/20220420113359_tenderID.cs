using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class tenderID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cdf_TenderSection",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    supporting_documentation = table.Column<int>(type: "int", nullable: true),
                    text_response = table.Column<int>(type: "int", nullable: true),
                    tenderID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cdf_TenderSection", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cdf_TenderSection");
        }
    }
}
