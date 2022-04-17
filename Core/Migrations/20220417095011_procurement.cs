using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class procurement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    BankID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    BankName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    LastChanged = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.BankID);
                });

            migrationBuilder.CreateTable(
                name: "Cdf_Admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Organization_Id = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<int>(type: "int", nullable: true),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cdf_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_Asset",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    asset = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    asset_type = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    createdBy = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_Asset", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_AssetType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assetType = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    createdBy = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_AssetType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_Bid",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    supplierID = table.Column<int>(type: "int", nullable: true),
                    tenderID = table.Column<int>(type: "int", nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    details = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_Bid", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_Budget",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    period = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    budgetYear = table.Column<int>(type: "int", nullable: true),
                    createdBy = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    budgetName = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_Budget", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_BudgetExpense",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    amount = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    currency = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    budget_id = table.Column<int>(type: "int", nullable: true),
                    code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_BudgetExpense", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_BudgetPeriod",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    period = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    budget_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_BudgetPeriod", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_BudgetRevenue",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    amount = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    currency = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    budget_id = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_BudgetRevenue", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_CompanyType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_CompanyType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_Constituency",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    constituency = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    longitude = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    latitude = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    province = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    country = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CDF_Department",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    department = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_Department", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_EVALUATIONMETHOD",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    method = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_EVALUATIONMETHOD", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_ExpenseType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    expenseType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    createdBy = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_ExpenseType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_Fund",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fund = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    amount = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    currency = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    currency_code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CDF_IdentityType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CDF_Levels",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    levelInOrganization = table.Column<int>(type: "int", nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    numberOfUsers = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_Levels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_ORGANIZATION",
                columns: table => new
                {
                    name = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_Admin_Identity_Type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    first_Admin_ID = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    first_Admin_Phone = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    first_Admin_Email = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    activated = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    logo = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_ORGANIZATION", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "CDF_OrganizationActivation",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_id = table.Column<int>(type: "int", nullable: true),
                    activationCode = table.Column<int>(type: "int", nullable: true),
                    activation = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CDF_ORGANIZATIONBRANCHES",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    branchName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    branchAddress = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CDF_ORGANIZATIONDEPARTMENTS",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departmentName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    departmentHeadJobID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CDF_ORGANIZATIONJOBS",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_level = table.Column<int>(type: "int", nullable: true),
                    organization_title = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    strength = table.Column<int>(type: "int", nullable: true),
                    organization_grade = table.Column<int>(type: "int", nullable: true),
                    organization_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CDF_ORGANIZATIONPROFILE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LegalName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CompanyWebsite = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    companyEmail = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    companyAddress = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    organization_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CDF_Permission",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    permission = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CDF_PlanItems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    @class = table.Column<string>(name: "class", type: "varchar(max)", unicode: false, nullable: false),
                    UNSPSC = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Description = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Ref_No = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Project_Code = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    unitofmeasure = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    source_of_funds = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Prequalification = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    procurement_method = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    publication = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Award = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Start = table.Column<DateTime>(type: "datetime", nullable: true),
                    Comments = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    typeofentry = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_PlanItems", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CDF_ProcPlan",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    entityID = table.Column<int>(type: "int", nullable: true),
                    year = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    version = table.Column<int>(type: "int", nullable: true),
                    modified = table.Column<DateTime>(type: "datetime", nullable: true),
                    comments = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_ProcPlan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CDF_Procurement",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    method = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    numberOfBidders = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_Procurement", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_ProcurementEntity",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    entityName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    type = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_ProcurementEntity", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CDF_ProcurementEntityType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_ProcurementEntityType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CDF_Role",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    role = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    levelID = table.Column<int>(type: "int", nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    createdBy = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_Role", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_Roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    role = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_Roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_Services",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    service = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    createdBy = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_Services", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_Status",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CDF_Stock",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stock = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    stockCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    createdBy = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_Stock", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_Tender",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    dueDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    shortDescription = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    longDescription = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    tenderSerial = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    tenderProcedure = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    tenderProcurementTechnique = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    submissionDeadline = table.Column<DateTime>(type: "datetime", nullable: true),
                    clarificationDeadline = table.Column<DateTime>(type: "datetime", nullable: true),
                    invitationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    contractNoticeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    evaluationMechanism = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    department = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    units = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('Submission')"),
                    budget_expense_id = table.Column<int>(type: "int", nullable: true),
                    budget_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_Tender", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_TenderCategory",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    uom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_TenderCategory", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_TenderProcedure",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenderProcedure = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    numberofBidders = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_TenderProcedure", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_User",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    fname = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    lname = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    consituency_id = table.Column<int>(type: "int", nullable: true),
                    type = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<int>(type: "int", nullable: true),
                    date_created = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    createdBy = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    role_id = table.Column<int>(type: "int", nullable: true),
                    department_id = table.Column<int>(type: "int", nullable: true),
                    logo = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    phone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    password = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    emailConfirmed = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_User", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    logo = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    organization_id = table.Column<int>(type: "int", nullable: true),
                    role_id = table.Column<int>(type: "int", nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    createdBy = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CDF_UserType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDF_UserType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CdfConstituency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Constituency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CdfConstituency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CdfFund",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fund = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CdfFund", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CdfIdentityType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CdfIdentityType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CdfOrganization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstAdminIdentityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstAdminId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstAdminPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstAdminEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Activated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FirstAdminUsername = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CdfOrganization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CdfRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CdfRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CdfStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CdfStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CdfUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsituencyId = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CdfUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CdfUserType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CdfUserType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CEEC_CATEGORY",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "CountryNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CountryName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    CountryPhoneCode = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currency_Symbol",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    country = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    currency = table.Column<string>(type: "varchar(39)", unicode: false, maxLength: 39, nullable: false),
                    code = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    symbol = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency_Symbol", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CurrencySymbol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencySymbol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    LongDescription = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    LastChanged = table.Column<DateTime>(type: "datetime", nullable: true),
                    ChangedByUser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('A')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FileType = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    FileData = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Modified = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    SupplierID = table.Column<int>(type: "int", nullable: true),
                    TenderID = table.Column<int>(type: "int", nullable: true),
                    bidID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeHistory",
                columns: table => new
                {
                    EmployeeHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeCode = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    EmployeeStatusId = table.Column<int>(type: "int", nullable: false),
                    TerminationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TerminationReasonId = table.Column<int>(type: "int", nullable: true),
                    DateEngaged = table.Column<DateTime>(type: "datetime", nullable: true),
                    JobGradeId = table.Column<int>(type: "int", nullable: true),
                    JobTitleId = table.Column<int>(type: "int", nullable: true),
                    PositionCode = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    JobGeneralId = table.Column<int>(type: "int", nullable: true),
                    NatureOfContractId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeHistory", x => x.EmployeeHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusCode = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    StatusDescription = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeStatus", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTimeSheet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    HoursWorked = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DateWorked = table.Column<DateTime>(type: "date", nullable: true),
                    PeriodStartDate = table.Column<DateTime>(type: "date", nullable: true),
                    PeriodEndDate = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "date", nullable: true),
                    ApprovedBy = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DateApproved = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTimeSheet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ErrorLog",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ErrorDescription = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    DateLogged = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorLog", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nchar(2)", fixedLength: true, maxLength: 2, nullable: false),
                    LongDescription = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "HistoryPayrollRuns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    PayPeriod = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryPayrollRuns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IDNumberType",
                columns: table => new
                {
                    IDNumberTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    LongDescription = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IDNumberType", x => x.IDNumberTypeID);
                });

            migrationBuilder.CreateTable(
                name: "IncreaseHistory",
                columns: table => new
                {
                    IncreaseHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    IncreaseReasonTypeID = table.Column<int>(type: "int", nullable: true),
                    IncreaseAppliedOn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IncreaseAmount = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    IncreasePercentage = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    PreviousAnnualSalary = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    NewAnnualSalary = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    PreviousMonthlySalary = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    NewMonthlySalary = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    PreviousRatePerHour = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    NewRatePerHour = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    PreviousRatePerDay = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    NewRatePerDay = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    JobGradeID = table.Column<int>(type: "int", nullable: true),
                    JobTitleID = table.Column<int>(type: "int", nullable: true),
                    EffectiveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IncreaseProcessedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProcessedByUserID = table.Column<int>(type: "int", nullable: true),
                    LastChanged = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncreaseHistory", x => x.IncreaseHistoryID);
                });

            migrationBuilder.CreateTable(
                name: "IncreaseReason",
                columns: table => new
                {
                    IncreaseReasonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    LongDescription = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Status = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    UserID = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    LastChanged = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncreaseReason", x => x.IncreaseReasonID);
                });

            migrationBuilder.CreateTable(
                name: "JobGeneral",
                columns: table => new
                {
                    JobGeneralID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LongDescription = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobGeneral", x => x.JobGeneralID);
                });

            migrationBuilder.CreateTable(
                name: "JobGrade",
                columns: table => new
                {
                    JobGradeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobGradeCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    JobGradeDescription = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobGrade", x => x.JobGradeID);
                });

            migrationBuilder.CreateTable(
                name: "LeaveTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    EmployeeCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LeaveStartDate = table.Column<DateTime>(type: "date", nullable: true),
                    LeaveEndDate = table.Column<DateTime>(type: "date", nullable: true),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: true),
                    UnitsTaken = table.Column<int>(type: "int", nullable: true),
                    DateApplied = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    DateApproved = table.Column<DateTime>(type: "date", nullable: true),
                    ApprovedBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveTransactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    LeaveTypeDescription = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Entitlement = table.Column<int>(type: "int", nullable: false),
                    ApplicableGender = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Cycle = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    BalanceBroughtForwardOption = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "date", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                columns: table => new
                {
                    MaritalStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LongDescription = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.MaritalStatusId);
                });

            migrationBuilder.CreateTable(
                name: "NapsaConfiguration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Percentage = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    MaximumCeiling = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "date", nullable: true),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NapsaConfiguration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NatureOfContract",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractTypeCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ContractTypeDecsription = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NatureOfContract", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhimaConfiguration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Percentage = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhimaConfiguration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PayrollDeductionDef",
                columns: table => new
                {
                    DefID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeductionCode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    DeductionDecsription = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Formula = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Status = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    LineFlag = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollDeductionDef", x => x.DefID);
                });

            migrationBuilder.CreateTable(
                name: "PayrollEarningDef",
                columns: table => new
                {
                    DefID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EarningLineCode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    EarningLineDescription = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Formula = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Status = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    LineFlag = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollEarningDef", x => x.DefID);
                });

            migrationBuilder.CreateTable(
                name: "PayrollLinesFrequecyCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollLinesFrequecyCodes", x => x.Id);
                    table.UniqueConstraint("AK_PayrollLinesFrequecyCodes_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "PayslipDetail",
                columns: table => new
                {
                    PayslipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    DeductionDefId = table.Column<int>(type: "int", nullable: true),
                    DeductionAmount = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    EarningDefId = table.Column<int>(type: "int", nullable: true),
                    EarningAmount = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    PayPeriod = table.Column<DateTime>(type: "datetime", nullable: true),
                    LineFlag = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayslipDetail", x => x.PayslipId);
                });

            migrationBuilder.CreateTable(
                name: "PayslipDetailArchive",
                columns: table => new
                {
                    PayslipArchiveID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpoyeeID = table.Column<int>(type: "int", nullable: true),
                    DeductionDefID = table.Column<int>(type: "int", nullable: true),
                    DeductionAmount = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    EarningDefID = table.Column<int>(type: "int", nullable: true),
                    EarningAmount = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    PayPeriod = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExportDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExportedByUserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayslipDetailArchive", x => x.PayslipArchiveID);
                });

            migrationBuilder.CreateTable(
                name: "PromotionHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    OldPositionCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NewPositionCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    PromotionDate = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "reference",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: true),
                    reference = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "StatusDescription",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusCode = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    StausDescription = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralStatusDescription", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier_RegAttachment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    attachment = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    attachmentType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SupplierRegistation",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    supplierRegistrationCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    companyRegistrationNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TPIN = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    organizationName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    organizationType = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    country = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    phone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    countryOfRegistration = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    shareholders = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    companyStatusZRA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    companyStatusNapsa = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    confirmationCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierRegistation", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TaxTableDefinition",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BandDescription = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LowerLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UperLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Percentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxTableDefinition", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TerminationReason",
                columns: table => new
                {
                    TerminationReasonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerminationReason", x => x.TerminationReasonId);
                });

            migrationBuilder.CreateTable(
                name: "TitleDescription",
                columns: table => new
                {
                    TitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleDescription = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleDescription", x => x.TitleId);
                });

            migrationBuilder.CreateTable(
                name: "UserAuditLogs",
                columns: table => new
                {
                    AuditID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    UserName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ActionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ActionType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Action = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    FieldName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    OldValue = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    NewValue = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAuditLogs", x => x.AuditID);
                });

            migrationBuilder.CreateTable(
                name: "UserMenu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuDescription = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMenu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleDescription = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UserRoleID);
                });

            migrationBuilder.CreateTable(
                name: "UserStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusDescription = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStatus", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankBranch",
                columns: table => new
                {
                    BranchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankID = table.Column<int>(type: "int", nullable: false),
                    BranchCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    BranchName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    LastChanged = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankBranch", x => x.BranchID);
                    table.ForeignKey(
                        name: "FK_BankBranch_Bank",
                        column: x => x.BankID,
                        principalTable: "Bank",
                        principalColumn: "BankID");
                });

            migrationBuilder.CreateTable(
                name: "JobTitle",
                columns: table => new
                {
                    JobTitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jobcode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    LongDescription = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    JobGradeId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    LastChanged = table.Column<DateTime>(type: "datetime", nullable: true),
                    ChangedByUser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitle", x => x.JobTitleId);
                    table.UniqueConstraint("AK_JobTitle_Jobcode", x => x.Jobcode);
                    table.ForeignKey(
                        name: "FK_JobTitle_JobGrade",
                        column: x => x.JobGradeId,
                        principalTable: "JobGrade",
                        principalColumn: "JobGradeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entity",
                columns: table => new
                {
                    EntityCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    SecondName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    MaidenName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    TitleID = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Gender = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Nationality = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MaritalStatusID = table.Column<int>(type: "int", nullable: false),
                    IDNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IDNumberType = table.Column<int>(type: "int", nullable: true),
                    EmployeeStatusID = table.Column<int>(type: "int", nullable: false),
                    SocialSecurityNumber = table.Column<int>(type: "int", nullable: true),
                    WorkNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CellNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    EmailAddress = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    WorkAddress = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    PhysicalAddress = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    CountryOfBirthID = table.Column<int>(type: "int", nullable: false),
                    BankID = table.Column<int>(type: "int", nullable: true),
                    BankBranchID = table.Column<int>(type: "int", nullable: true),
                    AccountName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    AccountNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastChanged = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity", x => x.EntityCode);
                    table.ForeignKey(
                        name: "FK_Entity_CountryNames",
                        column: x => x.CountryOfBirthID,
                        principalTable: "CountryNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entity_EmployeeStatus",
                        column: x => x.EmployeeStatusID,
                        principalTable: "EmployeeStatus",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entity_IDNumberType",
                        column: x => x.IDNumberType,
                        principalTable: "IDNumberType",
                        principalColumn: "IDNumberTypeID");
                    table.ForeignKey(
                        name: "FK_Entity_MaritalStatus",
                        column: x => x.MaritalStatusID,
                        principalTable: "MaritalStatus",
                        principalColumn: "MaritalStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entity_TitleDescription",
                        column: x => x.TitleID,
                        principalTable: "TitleDescription",
                        principalColumn: "TitleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMenuMapping",
                columns: table => new
                {
                    UserMenuMappingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRoleID = table.Column<int>(type: "int", nullable: false),
                    UserMenuID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMenuMapping", x => x.UserMenuMappingID);
                    table.ForeignKey(
                        name: "FK_UserMenuMapping_UserMenu",
                        column: x => x.UserMenuID,
                        principalTable: "UserMenu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMenuMapping_UserRoles",
                        column: x => x.UserRoleID,
                        principalTable: "UserRoles",
                        principalColumn: "UserRoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDetail",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeId = table.Column<int>(type: "int", nullable: true),
                    Username = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    EmailAddress = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    UserRoleID = table.Column<int>(type: "int", nullable: false),
                    ProfileStatus = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastLogon = table.Column<DateTime>(type: "datetime", nullable: true),
                    FailedLoginAttempts = table.Column<int>(type: "int", nullable: true),
                    organization_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetail", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserDetail_UserRoles",
                        column: x => x.UserRoleID,
                        principalTable: "UserRoles",
                        principalColumn: "UserRoleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetail_UserStatus",
                        column: x => x.ProfileStatus,
                        principalTable: "UserStatus",
                        principalColumn: "StatusID");
                });

            migrationBuilder.CreateTable(
                name: "PositionDetails",
                columns: table => new
                {
                    PositionCodeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitleCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    PositionCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    LongDescription = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    ReportsToPositionCode = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    EmployeeCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    VacancyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionDetails", x => x.PositionCodeId);
                    table.ForeignKey(
                        name: "FK_PositionDetails_Department",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentID");
                    table.ForeignKey(
                        name: "FK_PositionDetails_JobTitle",
                        column: x => x.JobTitleCode,
                        principalTable: "JobTitle",
                        principalColumn: "Jobcode");
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityID = table.Column<int>(type: "int", nullable: false),
                    EmployeeCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DateEngaged = table.Column<DateTime>(type: "datetime", nullable: true),
                    LeaveStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PensionStartDate = table.Column<DateTime>(type: "date", nullable: true),
                    TerminationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TerminationReasonID = table.Column<int>(type: "int", nullable: false),
                    JobTitleID = table.Column<int>(type: "int", nullable: false),
                    JobGradeID = table.Column<int>(type: "int", nullable: false),
                    JobGeneralID = table.Column<int>(type: "int", nullable: false),
                    EmployeeStatusID = table.Column<int>(type: "int", nullable: false),
                    ReportToEmployeeID = table.Column<int>(type: "int", nullable: true),
                    NatureOfContractID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employee_Department",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_EmployeeStatus",
                        column: x => x.EmployeeStatusID,
                        principalTable: "EmployeeStatus",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Entity",
                        column: x => x.EntityID,
                        principalTable: "Entity",
                        principalColumn: "EntityCode");
                    table.ForeignKey(
                        name: "FK_Employee_JobGeneral",
                        column: x => x.JobGeneralID,
                        principalTable: "JobGeneral",
                        principalColumn: "JobGeneralID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_JobGrade",
                        column: x => x.JobGradeID,
                        principalTable: "JobGrade",
                        principalColumn: "JobGradeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_JobTitle",
                        column: x => x.JobTitleID,
                        principalTable: "JobTitle",
                        principalColumn: "JobTitleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_NatureOfContract",
                        column: x => x.NatureOfContractID,
                        principalTable: "NatureOfContract",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_TerminationReason",
                        column: x => x.TerminationReasonID,
                        principalTable: "TerminationReason",
                        principalColumn: "TerminationReasonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPasswordResets",
                columns: table => new
                {
                    ResetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ResetToken = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    ResetDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TokenStatusID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPasswordResets", x => x.ResetID);
                    table.ForeignKey(
                        name: "FK_UserPasswordResets_UserDetail",
                        column: x => x.UserId,
                        principalTable: "UserDetail",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DisciplinaryCases",
                columns: table => new
                {
                    CaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CaseType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CaseDescription = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Category = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DateOffenceCommitted = table.Column<DateTime>(type: "date", nullable: true),
                    CaseOutcome = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplinaryCases", x => x.CaseId);
                    table.ForeignKey(
                        name: "FK_DisciplinaryCases_Employee",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeBankDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    AccountName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AccountNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    IsDefaultBank = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeBankDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeBankDetails_Employee",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeQualifications",
                columns: table => new
                {
                    FileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuId = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DocumentType = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    QualificationType = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FieldOfStudy = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    DocumentContent = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DocumentName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeQualifications", x => x.FileId);
                    table.ForeignKey(
                        name: "FK_EmployeeQualifications_Employee",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeRemuneration",
                columns: table => new
                {
                    RemunerationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    RemunerationAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true),
                    Reason = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "date", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserId = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRemuneration", x => x.RemunerationID);
                    table.ForeignKey(
                        name: "FK_EmployeeRemuneration_Employee",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID");
                });

            migrationBuilder.CreateTable(
                name: "LeaveDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    LeaveAccrualStartDate = table.Column<DateTime>(type: "date", nullable: true),
                    LeaveBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MonetaryEquivalent = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveDetail_Employee",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID");
                });

            migrationBuilder.CreateTable(
                name: "PayslipDefinition",
                columns: table => new
                {
                    PayslipDefId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PayrollDefinitionCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    OccurenceCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    PeriodStartDate = table.Column<DateTime>(type: "date", nullable: false),
                    PeriodEndDate = table.Column<DateTime>(type: "date", nullable: false),
                    PayPeriod = table.Column<int>(type: "int", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    PayrollDefinitionFlag = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayslipDefinition", x => x.PayslipDefId);
                    table.ForeignKey(
                        name: "FK_PayslipDefinition_Employee",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID");
                    table.ForeignKey(
                        name: "FK_PayslipDefinition_PayrollLinesFrequecyCodes",
                        column: x => x.OccurenceCode,
                        principalTable: "PayrollLinesFrequecyCodes",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Bank",
                table: "Bank",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BankBranch",
                table: "BankBranch",
                column: "BranchCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BankBranch_BankID",
                table: "BankBranch",
                column: "BankID");

            migrationBuilder.CreateIndex(
                name: "IX_CountryNames",
                table: "CountryNames",
                column: "CountryCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department",
                table: "Department",
                column: "DepartmentCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DisciplinaryCases_EmployeeId",
                table: "DisciplinaryCases",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee",
                table: "Employee",
                column: "EmployeeCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_1",
                table: "Employee",
                column: "EntityID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentID",
                table: "Employee",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeStatusID",
                table: "Employee",
                column: "EmployeeStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_JobGeneralID",
                table: "Employee",
                column: "JobGeneralID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_JobGradeID",
                table: "Employee",
                column: "JobGradeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_JobTitleID",
                table: "Employee",
                column: "JobTitleID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_NatureOfContractID",
                table: "Employee",
                column: "NatureOfContractID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_TerminationReasonID",
                table: "Employee",
                column: "TerminationReasonID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBankDetails",
                table: "EmployeeBankDetails",
                column: "AccountNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBankDetails_EmployeeId",
                table: "EmployeeBankDetails",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeQualifications_EmployeeId",
                table: "EmployeeQualifications",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRemuneration_EmployeeId",
                table: "EmployeeRemuneration",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeStatus",
                table: "EmployeeStatus",
                column: "StatusCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entity",
                table: "Entity",
                column: "IDNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entity_CountryOfBirthID",
                table: "Entity",
                column: "CountryOfBirthID");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_EmployeeStatusID",
                table: "Entity",
                column: "EmployeeStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_IDNumberType",
                table: "Entity",
                column: "IDNumberType");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_MaritalStatusID",
                table: "Entity",
                column: "MaritalStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_TitleID",
                table: "Entity",
                column: "TitleID");

            migrationBuilder.CreateIndex(
                name: "IX_Gender",
                table: "Gender",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IDNumberType",
                table: "IDNumberType",
                column: "IDCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IncreaseReason",
                table: "IncreaseReason",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobGrade",
                table: "JobGrade",
                column: "JobGradeCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobTitle",
                table: "JobTitle",
                column: "Jobcode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobTitle_JobGradeId",
                table: "JobTitle",
                column: "JobGradeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveDetail_EmployeeId",
                table: "LeaveDetail",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveTypes",
                table: "LeaveTypes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NatureOfContract",
                table: "NatureOfContract",
                column: "ContractTypeCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PayrollDeductionDef",
                table: "PayrollDeductionDef",
                column: "DeductionCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PayrollEarningDef",
                table: "PayrollEarningDef",
                column: "EarningLineCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PayrollLinesFrequecyCodes",
                table: "PayrollLinesFrequecyCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PayslipDefinition_EmployeeId",
                table: "PayslipDefinition",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PayslipDefinition_OccurenceCode",
                table: "PayslipDefinition",
                column: "OccurenceCode");

            migrationBuilder.CreateIndex(
                name: "IX_PositionDetails",
                table: "PositionDetails",
                column: "PositionCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PositionDetails_DepartmentId",
                table: "PositionDetails",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PositionDetails_JobTitleCode",
                table: "PositionDetails",
                column: "JobTitleCode");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralStatusDescription",
                table: "StatusDescription",
                column: "StatusID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TerminationReason",
                table: "TerminationReason",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserDetail",
                table: "UserDetail",
                column: "EmployeId",
                unique: true,
                filter: "[EmployeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetail_1",
                table: "UserDetail",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserDetail_ProfileStatus",
                table: "UserDetail",
                column: "ProfileStatus");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetail_UserRoleID",
                table: "UserDetail",
                column: "UserRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_UserMenuMapping_UserMenuID",
                table: "UserMenuMapping",
                column: "UserMenuID");

            migrationBuilder.CreateIndex(
                name: "IX_UserMenuMapping_UserRoleID",
                table: "UserMenuMapping",
                column: "UserRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPasswordResets",
                table: "UserPasswordResets",
                column: "ResetID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPasswordResets_1",
                table: "UserPasswordResets",
                column: "ResetID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPasswordResets_UserId",
                table: "UserPasswordResets",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BankBranch");

            migrationBuilder.DropTable(
                name: "Cdf_Admin");

            migrationBuilder.DropTable(
                name: "CDF_Asset");

            migrationBuilder.DropTable(
                name: "CDF_AssetType");

            migrationBuilder.DropTable(
                name: "CDF_Bid");

            migrationBuilder.DropTable(
                name: "CDF_Budget");

            migrationBuilder.DropTable(
                name: "CDF_BudgetExpense");

            migrationBuilder.DropTable(
                name: "CDF_BudgetPeriod");

            migrationBuilder.DropTable(
                name: "CDF_BudgetRevenue");

            migrationBuilder.DropTable(
                name: "CDF_CompanyType");

            migrationBuilder.DropTable(
                name: "CDF_Constituency");

            migrationBuilder.DropTable(
                name: "CDF_Department");

            migrationBuilder.DropTable(
                name: "CDF_EVALUATIONMETHOD");

            migrationBuilder.DropTable(
                name: "CDF_ExpenseType");

            migrationBuilder.DropTable(
                name: "CDF_Fund");

            migrationBuilder.DropTable(
                name: "CDF_IdentityType");

            migrationBuilder.DropTable(
                name: "CDF_Levels");

            migrationBuilder.DropTable(
                name: "CDF_ORGANIZATION");

            migrationBuilder.DropTable(
                name: "CDF_OrganizationActivation");

            migrationBuilder.DropTable(
                name: "CDF_ORGANIZATIONBRANCHES");

            migrationBuilder.DropTable(
                name: "CDF_ORGANIZATIONDEPARTMENTS");

            migrationBuilder.DropTable(
                name: "CDF_ORGANIZATIONJOBS");

            migrationBuilder.DropTable(
                name: "CDF_ORGANIZATIONPROFILE");

            migrationBuilder.DropTable(
                name: "CDF_Permission");

            migrationBuilder.DropTable(
                name: "CDF_PlanItems");

            migrationBuilder.DropTable(
                name: "CDF_ProcPlan");

            migrationBuilder.DropTable(
                name: "CDF_Procurement");

            migrationBuilder.DropTable(
                name: "CDF_ProcurementEntity");

            migrationBuilder.DropTable(
                name: "CDF_ProcurementEntityType");

            migrationBuilder.DropTable(
                name: "CDF_Role");

            migrationBuilder.DropTable(
                name: "CDF_Roles");

            migrationBuilder.DropTable(
                name: "CDF_Services");

            migrationBuilder.DropTable(
                name: "CDF_Status");

            migrationBuilder.DropTable(
                name: "CDF_Stock");

            migrationBuilder.DropTable(
                name: "CDF_Tender");

            migrationBuilder.DropTable(
                name: "CDF_TenderCategory");

            migrationBuilder.DropTable(
                name: "CDF_TenderProcedure");

            migrationBuilder.DropTable(
                name: "CDF_User");

            migrationBuilder.DropTable(
                name: "CDF_Users");

            migrationBuilder.DropTable(
                name: "CDF_UserType");

            migrationBuilder.DropTable(
                name: "CdfConstituency");

            migrationBuilder.DropTable(
                name: "CdfFund");

            migrationBuilder.DropTable(
                name: "CdfIdentityType");

            migrationBuilder.DropTable(
                name: "CdfOrganization");

            migrationBuilder.DropTable(
                name: "CdfRoles");

            migrationBuilder.DropTable(
                name: "CdfStatus");

            migrationBuilder.DropTable(
                name: "CdfUser");

            migrationBuilder.DropTable(
                name: "CdfUserType");

            migrationBuilder.DropTable(
                name: "CEEC_CATEGORY");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Currency_Symbol");

            migrationBuilder.DropTable(
                name: "CurrencySymbol");

            migrationBuilder.DropTable(
                name: "DisciplinaryCases");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "EmployeeBankDetails");

            migrationBuilder.DropTable(
                name: "EmployeeHistory");

            migrationBuilder.DropTable(
                name: "EmployeeQualifications");

            migrationBuilder.DropTable(
                name: "EmployeeRemuneration");

            migrationBuilder.DropTable(
                name: "EmployeeTimeSheet");

            migrationBuilder.DropTable(
                name: "ErrorLog");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "HistoryPayrollRuns");

            migrationBuilder.DropTable(
                name: "IncreaseHistory");

            migrationBuilder.DropTable(
                name: "IncreaseReason");

            migrationBuilder.DropTable(
                name: "LeaveDetail");

            migrationBuilder.DropTable(
                name: "LeaveTransactions");

            migrationBuilder.DropTable(
                name: "LeaveTypes");

            migrationBuilder.DropTable(
                name: "NapsaConfiguration");

            migrationBuilder.DropTable(
                name: "NhimaConfiguration");

            migrationBuilder.DropTable(
                name: "PayrollDeductionDef");

            migrationBuilder.DropTable(
                name: "PayrollEarningDef");

            migrationBuilder.DropTable(
                name: "PayslipDefinition");

            migrationBuilder.DropTable(
                name: "PayslipDetail");

            migrationBuilder.DropTable(
                name: "PayslipDetailArchive");

            migrationBuilder.DropTable(
                name: "PositionDetails");

            migrationBuilder.DropTable(
                name: "PromotionHistory");

            migrationBuilder.DropTable(
                name: "reference");

            migrationBuilder.DropTable(
                name: "StatusDescription");

            migrationBuilder.DropTable(
                name: "Supplier_RegAttachment");

            migrationBuilder.DropTable(
                name: "SupplierRegistation");

            migrationBuilder.DropTable(
                name: "TaxTableDefinition");

            migrationBuilder.DropTable(
                name: "UserAuditLogs");

            migrationBuilder.DropTable(
                name: "UserMenuMapping");

            migrationBuilder.DropTable(
                name: "UserPasswordResets");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "PayrollLinesFrequecyCodes");

            migrationBuilder.DropTable(
                name: "UserMenu");

            migrationBuilder.DropTable(
                name: "UserDetail");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Entity");

            migrationBuilder.DropTable(
                name: "JobGeneral");

            migrationBuilder.DropTable(
                name: "JobTitle");

            migrationBuilder.DropTable(
                name: "NatureOfContract");

            migrationBuilder.DropTable(
                name: "TerminationReason");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserStatus");

            migrationBuilder.DropTable(
                name: "CountryNames");

            migrationBuilder.DropTable(
                name: "EmployeeStatus");

            migrationBuilder.DropTable(
                name: "IDNumberType");

            migrationBuilder.DropTable(
                name: "MaritalStatus");

            migrationBuilder.DropTable(
                name: "TitleDescription");

            migrationBuilder.DropTable(
                name: "JobGrade");
        }
    }
}
