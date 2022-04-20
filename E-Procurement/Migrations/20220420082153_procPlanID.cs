using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Procurement.Migrations
{
    public partial class procPlanID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "CDF_User",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "budget",
                table: "CDF_PlanItems",
                type: "decimal(18, 0)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "createdBy",
                table: "CDF_PlanItems",
                unicode: false,
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "procPlanID",
                table: "CDF_PlanItems",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cdf_TenderSection",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(unicode: false, nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    supporting_documentation = table.Column<int>(nullable: true),
                    text_response = table.Column<int>(nullable: true)
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

            migrationBuilder.DropColumn(
                name: "budget",
                table: "CDF_PlanItems");

            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "CDF_PlanItems");

            migrationBuilder.DropColumn(
                name: "procPlanID",
                table: "CDF_PlanItems");

            migrationBuilder.AlterColumn<int>(
                name: "status",
                table: "CDF_User",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
