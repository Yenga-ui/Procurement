using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Procurement.Migrations
{
    public partial class updatedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "procEntity",
                table: "CDF_Users",
                unicode: false,
                maxLength: 300,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "procEntity",
                table: "CDF_Users");
        }
    }
}
