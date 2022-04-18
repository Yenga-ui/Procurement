using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class createdby : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "procEntity",
                table: "CDF_Users",
                type: "varchar(300)",
                unicode: false,
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "CDF_User",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "procEntity",
                table: "CDF_User",
                type: "varchar(200)",
                unicode: false,
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "CDF_ProcurementEntity",
                type: "varchar(max)",
                unicode: false,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "CDF_ProcurementEntity",
                type: "varchar(max)",
                unicode: false,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "budget",
                table: "CDF_PlanItems",
                type: "decimal(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "createdBy",
                table: "CDF_PlanItems",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "procEntity",
                table: "CDF_Users");

            migrationBuilder.DropColumn(
                name: "procEntity",
                table: "CDF_User");

            migrationBuilder.DropColumn(
                name: "description",
                table: "CDF_ProcurementEntity");

            migrationBuilder.DropColumn(
                name: "email",
                table: "CDF_ProcurementEntity");

            migrationBuilder.DropColumn(
                name: "budget",
                table: "CDF_PlanItems");

            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "CDF_PlanItems");

            migrationBuilder.AlterColumn<int>(
                name: "status",
                table: "CDF_User",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);
        }
    }
}
