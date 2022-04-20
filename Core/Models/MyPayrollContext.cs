using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Core.Models
{
    public partial class MyPayrollContext : DbContext
    {
        public MyPayrollContext()
        {
        }

        public MyPayrollContext(DbContextOptions<MyPayrollContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; } = null!;
        public virtual DbSet<Bank> Banks { get; set; } = null!;
        public virtual DbSet<BankBranch> BankBranches { get; set; } = null!;
        public virtual DbSet<CdfAdmin> CdfAdmins { get; set; } = null!;
        public virtual DbSet<CdfAsset> CdfAssets { get; set; } = null!;
        public virtual DbSet<CdfAssetType> CdfAssetTypes { get; set; } = null!;
        public virtual DbSet<CdfBid> CdfBids { get; set; } = null!;
        public virtual DbSet<CdfBudget> CdfBudgets { get; set; } = null!;
        public virtual DbSet<CdfBudgetExpense> CdfBudgetExpenses { get; set; } = null!;
        public virtual DbSet<CdfBudgetPeriod> CdfBudgetPeriods { get; set; } = null!;
        public virtual DbSet<CdfBudgetRevenue> CdfBudgetRevenues { get; set; } = null!;
        public virtual DbSet<CdfCompanyType> CdfCompanyTypes { get; set; } = null!;
        public virtual DbSet<CdfConstituency> CdfConstituencies { get; set; } = null!;
        public virtual DbSet<CdfConstituency1> CdfConstituencies1 { get; set; } = null!;
        public virtual DbSet<CdfDepartment> CdfDepartments { get; set; } = null!;
        public virtual DbSet<CdfEvaluationmethod> CdfEvaluationmethods { get; set; } = null!;
        public virtual DbSet<CdfExpenseType> CdfExpenseTypes { get; set; } = null!;
        public virtual DbSet<CdfFund> CdfFunds { get; set; } = null!;
        public virtual DbSet<CdfFund1> CdfFunds1 { get; set; } = null!;
        public virtual DbSet<CdfIdentityType> CdfIdentityTypes { get; set; } = null!;
        public virtual DbSet<CdfIdentityType1> CdfIdentityTypes1 { get; set; } = null!;
        public virtual DbSet<CdfLevel> CdfLevels { get; set; } = null!;
        public virtual DbSet<CdfOrganization> CdfOrganizations { get; set; } = null!;
        public virtual DbSet<CdfOrganization1> CdfOrganizations1 { get; set; } = null!;
        public virtual DbSet<CdfOrganizationActivation> CdfOrganizationActivations { get; set; } = null!;
        public virtual DbSet<CdfOrganizationbranch> CdfOrganizationbranches { get; set; } = null!;
        public virtual DbSet<CdfOrganizationdepartment> CdfOrganizationdepartments { get; set; } = null!;
        public virtual DbSet<CdfOrganizationjob> CdfOrganizationjobs { get; set; } = null!;
        public virtual DbSet<CdfOrganizationprofile> CdfOrganizationprofiles { get; set; } = null!;
        public virtual DbSet<CdfPermission> CdfPermissions { get; set; } = null!;
        public virtual DbSet<CdfPlanItem> CdfPlanItems { get; set; } = null!;
        public virtual DbSet<CdfProcPlan> CdfProcPlans { get; set; } = null!;
        public virtual DbSet<CdfProcurement> CdfProcurements { get; set; } = null!;
        public virtual DbSet<CdfProcurementEntity> CdfProcurementEntities { get; set; } = null!;
        public virtual DbSet<CdfProcurementEntityType> CdfProcurementEntityTypes { get; set; } = null!;
        public virtual DbSet<CdfRole> CdfRoles { get; set; } = null!;
        public virtual DbSet<CdfRole1> CdfRoles1 { get; set; } = null!;
        public virtual DbSet<CdfRole2> CdfRoles2 { get; set; } = null!;
        public virtual DbSet<CdfService> CdfServices { get; set; } = null!;
        public virtual DbSet<CdfStatus> CdfStatuses { get; set; } = null!;
        public virtual DbSet<CdfStatus1> CdfStatuses1 { get; set; } = null!;
        public virtual DbSet<CdfStock> CdfStocks { get; set; } = null!;
        public virtual DbSet<CdfTender> CdfTenders { get; set; } = null!;
        public virtual DbSet<CdfTenderCategory> CdfTenderCategories { get; set; } = null!;
        public virtual DbSet<CdfTenderProcedure> CdfTenderProcedures { get; set; } = null!;
        public virtual DbSet<CdfTenderSection> CdfTenderSections { get; set; } = null!;
        public virtual DbSet<CdfUser> CdfUsers { get; set; } = null!;
        public virtual DbSet<CdfUser1> CdfUsers1 { get; set; } = null!;
        public virtual DbSet<CdfUser2> CdfUsers2 { get; set; } = null!;
        public virtual DbSet<CdfUserType> CdfUserTypes { get; set; } = null!;
        public virtual DbSet<CdfUserType1> CdfUserTypes1 { get; set; } = null!;
        public virtual DbSet<CeecCategory> CeecCategories { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<CountryName> CountryNames { get; set; } = null!;
        public virtual DbSet<CurrencySymbol> CurrencySymbols { get; set; } = null!;
        public virtual DbSet<CurrencySymbol1> CurrencySymbols1 { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<DisciplinaryCase> DisciplinaryCases { get; set; } = null!;
        public virtual DbSet<Document> Documents { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeBankDetail> EmployeeBankDetails { get; set; } = null!;
        public virtual DbSet<EmployeeBankDetailsView> EmployeeBankDetailsViews { get; set; } = null!;
        public virtual DbSet<EmployeeDetail> EmployeeDetails { get; set; } = null!;
        public virtual DbSet<EmployeeHistory> EmployeeHistories { get; set; } = null!;
        public virtual DbSet<EmployeeQualification> EmployeeQualifications { get; set; } = null!;
        public virtual DbSet<EmployeeQualificationsView> EmployeeQualificationsViews { get; set; } = null!;
        public virtual DbSet<EmployeeRemuneration> EmployeeRemunerations { get; set; } = null!;
        public virtual DbSet<EmployeeStatus> EmployeeStatuses { get; set; } = null!;
        public virtual DbSet<EmployeeTimeSheet> EmployeeTimeSheets { get; set; } = null!;
        public virtual DbSet<Entity> Entities { get; set; } = null!;
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; } = null!;
        public virtual DbSet<Gender> Genders { get; set; } = null!;
        public virtual DbSet<HistoryPayrollRun> HistoryPayrollRuns { get; set; } = null!;
        public virtual DbSet<IdnumberType> IdnumberTypes { get; set; } = null!;
        public virtual DbSet<IncreaseHistory> IncreaseHistories { get; set; } = null!;
        public virtual DbSet<IncreaseReason> IncreaseReasons { get; set; } = null!;
        public virtual DbSet<JobGeneral> JobGenerals { get; set; } = null!;
        public virtual DbSet<JobGrade> JobGrades { get; set; } = null!;
        public virtual DbSet<JobTitle> JobTitles { get; set; } = null!;
        public virtual DbSet<LeaveDetail> LeaveDetails { get; set; } = null!;
        public virtual DbSet<LeaveEntitlementView> LeaveEntitlementViews { get; set; } = null!;
        public virtual DbSet<LeaveTransaction> LeaveTransactions { get; set; } = null!;
        public virtual DbSet<LeaveType> LeaveTypes { get; set; } = null!;
        public virtual DbSet<MaritalStatus> MaritalStatuses { get; set; } = null!;
        public virtual DbSet<NapsaConfiguration> NapsaConfigurations { get; set; } = null!;
        public virtual DbSet<NatureOfContract> NatureOfContracts { get; set; } = null!;
        public virtual DbSet<NhimaConfiguration> NhimaConfigurations { get; set; } = null!;
        public virtual DbSet<PayrollDeductionDef> PayrollDeductionDefs { get; set; } = null!;
        public virtual DbSet<PayrollEarningDef> PayrollEarningDefs { get; set; } = null!;
        public virtual DbSet<PayrollLinesFrequecyCode> PayrollLinesFrequecyCodes { get; set; } = null!;
        public virtual DbSet<PayrollRunDetailsView> PayrollRunDetailsViews { get; set; } = null!;
        public virtual DbSet<PayslipDefinition> PayslipDefinitions { get; set; } = null!;
        public virtual DbSet<PayslipDetail> PayslipDetails { get; set; } = null!;
        public virtual DbSet<PayslipDetailArchive> PayslipDetailArchives { get; set; } = null!;
        public virtual DbSet<PositionCodesView> PositionCodesViews { get; set; } = null!;
        public virtual DbSet<PositionDetail> PositionDetails { get; set; } = null!;
        public virtual DbSet<PromotionHistory> PromotionHistories { get; set; } = null!;
        public virtual DbSet<Reference> References { get; set; } = null!;
        public virtual DbSet<StatusDescription> StatusDescriptions { get; set; } = null!;
        public virtual DbSet<SupplierRegAttachment> SupplierRegAttachments { get; set; } = null!;
        public virtual DbSet<SupplierRegistation> SupplierRegistations { get; set; } = null!;
        public virtual DbSet<TaxTableDefinition> TaxTableDefinitions { get; set; } = null!;
        public virtual DbSet<TerminationReason> TerminationReasons { get; set; } = null!;
        public virtual DbSet<TitleDescription> TitleDescriptions { get; set; } = null!;
        public virtual DbSet<UserAuditLog> UserAuditLogs { get; set; } = null!;
        public virtual DbSet<UserDetail> UserDetails { get; set; } = null!;
        public virtual DbSet<UserMenu> UserMenus { get; set; } = null!;
        public virtual DbSet<UserMenuMapping> UserMenuMappings { get; set; } = null!;
        public virtual DbSet<UserPasswordReset> UserPasswordResets { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;
        public virtual DbSet<UserStatus> UserStatuses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-KT7SICT\\SQLEXPRESS;Initial Catalog=MyPayroll;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.Property(e => e.RoleId).HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                        r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId");

                            j.ToTable("AspNetUserRoles");
                        });
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("Bank");

                entity.HasIndex(e => e.Code, "IX_Bank")
                    .IsUnique();

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastChanged).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BankBranch>(entity =>
            {
                entity.HasKey(e => e.BranchId);

                entity.ToTable("BankBranch");

                entity.HasIndex(e => e.BranchCode, "IX_BankBranch")
                    .IsUnique();

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastChanged).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.BankBranches)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankBranch_Bank");
            });

            modelBuilder.Entity<CdfAdmin>(entity =>
            {
                entity.ToTable("Cdf_Admin");

                entity.Property(e => e.Fname).HasColumnName("FName");

                entity.Property(e => e.Lname).HasColumnName("LName");

                entity.Property(e => e.OrganizationId).HasColumnName("Organization_Id");
            });

            modelBuilder.Entity<CdfAsset>(entity =>
            {
                entity.ToTable("CDF_Asset");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Asset)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("asset");

                entity.Property(e => e.AssetType)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("asset_type");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("createdBy");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreated")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CdfAssetType>(entity =>
            {
                entity.ToTable("CDF_AssetType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssetType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("assetType");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("createdBy");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CdfBid>(entity =>
            {
                entity.ToTable("CDF_Bid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Details)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.SupplierId).HasColumnName("supplierID");

                entity.Property(e => e.TenderId).HasColumnName("tenderID");
            });

            modelBuilder.Entity<CdfBudget>(entity =>
            {
                entity.ToTable("CDF_Budget");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BudgetName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("budgetName");

                entity.Property(e => e.BudgetYear).HasColumnName("budgetYear");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("createdBy");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Period)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("period");
            });

            modelBuilder.Entity<CdfBudgetExpense>(entity =>
            {
                entity.ToTable("CDF_BudgetExpense");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("amount");

                entity.Property(e => e.BudgetId).HasColumnName("budget_id");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("currency");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("description");
            });

            modelBuilder.Entity<CdfBudgetPeriod>(entity =>
            {
                entity.ToTable("CDF_BudgetPeriod");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BudgetId).HasColumnName("budget_id");

                entity.Property(e => e.Period)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("period");
            });

            modelBuilder.Entity<CdfBudgetRevenue>(entity =>
            {
                entity.ToTable("CDF_BudgetRevenue");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("amount");

                entity.Property(e => e.BudgetId).HasColumnName("budget_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("currency");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("description");
            });

            modelBuilder.Entity<CdfCompanyType>(entity =>
            {
                entity.ToTable("CDF_CompanyType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfConstituency>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CDF_Constituency");

                entity.Property(e => e.Constituency)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("constituency");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("latitude");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("longitude");

                entity.Property(e => e.Province)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("province");
            });

            modelBuilder.Entity<CdfConstituency1>(entity =>
            {
                entity.ToTable("CdfConstituency");
            });

            modelBuilder.Entity<CdfDepartment>(entity =>
            {
                entity.ToTable("CDF_Department");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Department)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("department");
            });

            modelBuilder.Entity<CdfEvaluationmethod>(entity =>
            {
                entity.ToTable("CDF_EVALUATIONMETHOD");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Method)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("method");
            });

            modelBuilder.Entity<CdfExpenseType>(entity =>
            {
                entity.ToTable("CDF_ExpenseType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("createdBy");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExpenseType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("expenseType");
            });

            modelBuilder.Entity<CdfFund>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CDF_Fund");

                entity.Property(e => e.Amount)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("amount");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("currency");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("currency_code");

                entity.Property(e => e.Fund)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("fund");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<CdfFund1>(entity =>
            {
                entity.ToTable("CdfFund");
            });

            modelBuilder.Entity<CdfIdentityType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CDF_IdentityType");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<CdfIdentityType1>(entity =>
            {
                entity.ToTable("CdfIdentityType");
            });

            modelBuilder.Entity<CdfLevel>(entity =>
            {
                entity.ToTable("CDF_Levels");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LevelInOrganization).HasColumnName("levelInOrganization");

                entity.Property(e => e.NumberOfUsers).HasColumnName("numberOfUsers");
            });

            modelBuilder.Entity<CdfOrganization>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("CDF_ORGANIZATION");

                entity.Property(e => e.Name)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Activated)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("activated");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("date_created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FirstAdminEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("first_Admin_Email");

                entity.Property(e => e.FirstAdminId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("first_Admin_ID");

                entity.Property(e => e.FirstAdminIdentityType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("first_Admin_Identity_Type");

                entity.Property(e => e.FirstAdminPhone)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("first_Admin_Phone");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Logo).HasColumnName("logo");
            });

            modelBuilder.Entity<CdfOrganization1>(entity =>
            {
                entity.ToTable("CdfOrganization");

                entity.Property(e => e.FirstAdminUsername)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfOrganizationActivation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CDF_OrganizationActivation");

                entity.Property(e => e.Activation).HasColumnName("activation");

                entity.Property(e => e.ActivationCode).HasColumnName("activationCode");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");
            });

            modelBuilder.Entity<CdfOrganizationbranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CDF_ORGANIZATIONBRANCHES");

                entity.Property(e => e.BranchAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("branchAddress");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("branchName");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<CdfOrganizationdepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CDF_ORGANIZATIONDEPARTMENTS");

                entity.Property(e => e.DepartmentHeadJobId).HasColumnName("departmentHeadJobID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departmentName");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<CdfOrganizationjob>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CDF_ORGANIZATIONJOBS");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.OrganizationGrade).HasColumnName("organization_grade");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.OrganizationLevel).HasColumnName("organization_level");

                entity.Property(e => e.OrganizationTitle)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("organization_title");

                entity.Property(e => e.Strength).HasColumnName("strength");
            });

            modelBuilder.Entity<CdfOrganizationprofile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CDF_ORGANIZATIONPROFILE");

                entity.Property(e => e.CompanyAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("companyAddress");

                entity.Property(e => e.CompanyEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("companyEmail");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyWebsite)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LegalName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("organization_ID");
            });

            modelBuilder.Entity<CdfPermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CDF_Permission");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreated");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Permission)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("permission");
            });

            modelBuilder.Entity<CdfPlanItem>(entity =>
            {
                entity.ToTable("CDF_PlanItems");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Award).IsUnicode(false);

                entity.Property(e => e.Budget)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("budget");

                entity.Property(e => e.Class)
                    .IsUnicode(false)
                    .HasColumnName("class");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("createdBy");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Prequalification).IsUnicode(false);

                entity.Property(e => e.ProcPlanId).HasColumnName("procPlanID");

                entity.Property(e => e.ProcurementMethod)
                    .IsUnicode(false)
                    .HasColumnName("procurement_method");

                entity.Property(e => e.ProjectCode)
                    .IsUnicode(false)
                    .HasColumnName("Project_Code");

                entity.Property(e => e.Publication)
                    .IsUnicode(false)
                    .HasColumnName("publication");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RefNo)
                    .IsUnicode(false)
                    .HasColumnName("Ref_No");

                entity.Property(e => e.SourceOfFunds)
                    .IsUnicode(false)
                    .HasColumnName("source_of_funds");

                entity.Property(e => e.Start).HasColumnType("datetime");

                entity.Property(e => e.Typeofentry)
                    .IsUnicode(false)
                    .HasColumnName("typeofentry");

                entity.Property(e => e.Unitofmeasure)
                    .IsUnicode(false)
                    .HasColumnName("unitofmeasure");

                entity.Property(e => e.Unspsc)
                    .IsUnicode(false)
                    .HasColumnName("UNSPSC");
            });

            modelBuilder.Entity<CdfProcPlan>(entity =>
            {
                entity.ToTable("CDF_ProcPlan");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.EntityId).HasColumnName("entityID");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.Year)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("year");
            });

            modelBuilder.Entity<CdfProcurement>(entity =>
            {
                entity.ToTable("CDF_Procurement");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Method)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("method");

                entity.Property(e => e.NumberOfBidders).HasColumnName("numberOfBidders");
            });

            modelBuilder.Entity<CdfProcurementEntity>(entity =>
            {
                entity.ToTable("CDF_ProcurementEntity");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EntityName)
                    .IsUnicode(false)
                    .HasColumnName("entityName");

                entity.Property(e => e.Type)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<CdfProcurementEntityType>(entity =>
            {
                entity.ToTable("CDF_ProcurementEntityType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Type)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<CdfRole>(entity =>
            {
                entity.ToTable("CDF_Role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("createdBy");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LevelId).HasColumnName("levelID");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("role");
            });

            modelBuilder.Entity<CdfRole1>(entity =>
            {
                entity.ToTable("CDF_Roles");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("role");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<CdfRole2>(entity =>
            {
                entity.ToTable("CdfRoles");
            });

            modelBuilder.Entity<CdfService>(entity =>
            {
                entity.ToTable("CDF_Services");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("createdBy");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Service)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("service");
            });

            modelBuilder.Entity<CdfStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CDF_Status");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("date_created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<CdfStatus1>(entity =>
            {
                entity.ToTable("CdfStatus");

                entity.Property(e => e.DateCreated).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CdfStock>(entity =>
            {
                entity.ToTable("CDF_Stock");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("createdBy");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Stock)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("stock");

                entity.Property(e => e.StockCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stockCode");
            });

            modelBuilder.Entity<CdfTender>(entity =>
            {
                entity.ToTable("CDF_Tender");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BudgetExpenseId).HasColumnName("budget_expense_id");

                entity.Property(e => e.BudgetId).HasColumnName("budget_id");

                entity.Property(e => e.Category)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.ClarificationDeadline)
                    .HasColumnType("datetime")
                    .HasColumnName("clarificationDeadline");

                entity.Property(e => e.ContractNoticeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("contractNoticeDate");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Department)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("department");

                entity.Property(e => e.DueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dueDate");

                entity.Property(e => e.EvaluationMechanism)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("evaluationMechanism");

                entity.Property(e => e.InvitationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("invitationDate");

                entity.Property(e => e.LongDescription)
                    .IsUnicode(false)
                    .HasColumnName("longDescription");

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("shortDescription");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('Submission')");

                entity.Property(e => e.SubmissionDeadline)
                    .HasColumnType("datetime")
                    .HasColumnName("submissionDeadline");

                entity.Property(e => e.TenderProcedure)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("tenderProcedure");

                entity.Property(e => e.TenderProcurementTechnique)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("tenderProcurementTechnique");

                entity.Property(e => e.TenderSerial)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("tenderSerial");

                entity.Property(e => e.Units)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("units");
            });

            modelBuilder.Entity<CdfTenderCategory>(entity =>
            {
                entity.ToTable("CDF_TenderCategory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.Uom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("uom");
            });

            modelBuilder.Entity<CdfTenderProcedure>(entity =>
            {
                entity.ToTable("CDF_TenderProcedure");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NumberofBidders).HasColumnName("numberofBidders");

                entity.Property(e => e.TenderProcedure)
                    .IsUnicode(false)
                    .HasColumnName("tenderProcedure");
            });

            modelBuilder.Entity<CdfTenderSection>(entity =>
            {
                entity.ToTable("Cdf_TenderSection");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.SupportingDocumentation).HasColumnName("supporting_documentation");

                entity.Property(e => e.TextResponse).HasColumnName("text_response");

                entity.Property(e => e.Title)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<CdfUser>(entity =>
            {
                entity.ToTable("CDF_User");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConsituencyId).HasColumnName("consituency_id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("createdBy");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("date_created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmailConfirmed).HasColumnName("emailConfirmed");

                entity.Property(e => e.Fname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fname");

                entity.Property(e => e.Lname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lname");

                entity.Property(e => e.Logo).HasColumnName("logo");

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.ProcEntity)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("procEntity");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Username)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<CdfUser1>(entity =>
            {
                entity.ToTable("CDF_Users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("createdBy");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Logo).HasColumnName("logo");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.Password)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.ProcEntity)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("procEntity");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<CdfUser2>(entity =>
            {
                entity.ToTable("CdfUser");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfUserType>(entity =>
            {
                entity.ToTable("CDF_UserType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<CdfUserType1>(entity =>
            {
                entity.ToTable("CdfUserType");
            });

            modelBuilder.Entity<CeecCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CEEC_CATEGORY");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.CompanyName).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");
            });

            modelBuilder.Entity<CountryName>(entity =>
            {
                entity.HasIndex(e => e.CountryCode, "IX_CountryNames")
                    .IsUnique();

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CountryName");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CurrencySymbol>(entity =>
            {
                entity.ToTable("Currency_Symbol");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Country)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.Currency)
                    .HasMaxLength(39)
                    .IsUnicode(false)
                    .HasColumnName("currency");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(5)
                    .HasColumnName("symbol");
            });

            modelBuilder.Entity<CurrencySymbol1>(entity =>
            {
                entity.ToTable("CurrencySymbol");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.HasIndex(e => e.DepartmentCode, "IX_Department")
                    .IsUnique();

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.ChangedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastChanged).HasColumnType("datetime");

                entity.Property(e => e.LongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A')");
            });

            modelBuilder.Entity<DisciplinaryCase>(entity =>
            {
                entity.HasKey(e => e.CaseId);

                entity.Property(e => e.CaseDescription).IsUnicode(false);

                entity.Property(e => e.CaseOutcome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CaseType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateOffenceCommitted).HasColumnType("date");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.DisciplinaryCases)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DisciplinaryCases_Employee");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.ToTable("Document");

                entity.Property(e => e.BidId).HasColumnName("bidID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileName).HasMaxLength(250);

                entity.Property(e => e.FileType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.TenderId).HasColumnName("TenderID");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.HasIndex(e => e.EmployeeCode, "IX_Employee")
                    .IsUnique();

                entity.HasIndex(e => e.EntityId, "IX_Employee_1")
                    .IsUnique();

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateEngaged).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeStatusId).HasColumnName("EmployeeStatusID");

                entity.Property(e => e.EntityId).HasColumnName("EntityID");

                entity.Property(e => e.JobGeneralId).HasColumnName("JobGeneralID");

                entity.Property(e => e.JobGradeId).HasColumnName("JobGradeID");

                entity.Property(e => e.JobTitleId).HasColumnName("JobTitleID");

                entity.Property(e => e.LeaveStartDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NatureOfContractId).HasColumnName("NatureOfContractID");

                entity.Property(e => e.PensionStartDate).HasColumnType("date");

                entity.Property(e => e.ReportToEmployeeId).HasColumnName("ReportToEmployeeID");

                entity.Property(e => e.TerminationDate).HasColumnType("datetime");

                entity.Property(e => e.TerminationReasonId).HasColumnName("TerminationReasonID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Employee_Department");

                entity.HasOne(d => d.EmployeeStatus)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmployeeStatusId)
                    .HasConstraintName("FK_Employee_EmployeeStatus");

                entity.HasOne(d => d.Entity)
                    .WithOne(p => p.Employee)
                    .HasForeignKey<Employee>(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Entity");

                entity.HasOne(d => d.JobGeneral)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.JobGeneralId)
                    .HasConstraintName("FK_Employee_JobGeneral");

                entity.HasOne(d => d.JobGrade)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.JobGradeId)
                    .HasConstraintName("FK_Employee_JobGrade");

                entity.HasOne(d => d.JobTitle)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.JobTitleId)
                    .HasConstraintName("FK_Employee_JobTitle");

                entity.HasOne(d => d.NatureOfContract)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.NatureOfContractId)
                    .HasConstraintName("FK_Employee_NatureOfContract");

                entity.HasOne(d => d.TerminationReason)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.TerminationReasonId)
                    .HasConstraintName("FK_Employee_TerminationReason");
            });

            modelBuilder.Entity<EmployeeBankDetail>(entity =>
            {
                entity.HasIndex(e => e.AccountNumber, "IX_EmployeeBankDetails")
                    .IsUnique();

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeBankDetails)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeBankDetails_Employee");
            });

            modelBuilder.Entity<EmployeeBankDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EmployeeBankDetailsView");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EmployeeDetail");

                entity.Property(e => e.BasicPay).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BirthDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CellPhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateEngaged)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDNumber");

                entity.Property(e => e.JobGeneral)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JobGrade)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle).IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveStartDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaidenName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NatureOfContract)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PensionStartDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddress).IsUnicode(false);

                entity.Property(e => e.PositionCode)
                    .HasMaxLength(113)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeHistory>(entity =>
            {
                entity.ToTable("EmployeeHistory");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateEngaged).HasColumnType("datetime");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PositionCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeQualification>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.FieldOfStudy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GuId).IsUnicode(false);

                entity.Property(e => e.QualificationType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeQualifications)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_EmployeeQualifications_Employee");
            });

            modelBuilder.Entity<EmployeeQualificationsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EmployeeQualificationsView");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.FieldOfStudy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GuId).IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QualificationType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<EmployeeRemuneration>(entity =>
            {
                entity.HasKey(e => e.RemunerationId);

                entity.ToTable("EmployeeRemuneration");

                entity.Property(e => e.RemunerationId).HasColumnName("RemunerationID");

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Reason)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.RemunerationAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeRemunerations)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeRemuneration_Employee");
            });

            modelBuilder.Entity<EmployeeStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("EmployeeStatus");

                entity.HasIndex(e => e.StatusCode, "IX_EmployeeStatus")
                    .IsUnique();

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeTimeSheet>(entity =>
            {
                entity.ToTable("EmployeeTimeSheet");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateWorked).HasColumnType("date");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HoursWorked).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodEndDate).HasColumnType("date");

                entity.Property(e => e.PeriodStartDate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Entity>(entity =>
            {
                entity.HasKey(e => e.EntityCode);

                entity.ToTable("Entity");

                entity.HasIndex(e => e.Idnumber, "IX_Entity")
                    .IsUnique();

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankBranchId).HasColumnName("BankBranchID");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CountryOfBirthId).HasColumnName("CountryOfBirthID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeStatusId).HasColumnName("EmployeeStatusID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Idnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDNumber");

                entity.Property(e => e.IdnumberType).HasColumnName("IDNumberType");

                entity.Property(e => e.LastChanged).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaidenName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");

                entity.Property(e => e.Nationality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddress).IsUnicode(false);

                entity.Property(e => e.SecondName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TitleId).HasColumnName("TitleID");

                entity.Property(e => e.WorkAddress).IsUnicode(false);

                entity.Property(e => e.WorkNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CountryOfBirth)
                    .WithMany(p => p.Entities)
                    .HasForeignKey(d => d.CountryOfBirthId)
                    .HasConstraintName("FK_Entity_CountryNames");

                entity.HasOne(d => d.EmployeeStatus)
                    .WithMany(p => p.Entities)
                    .HasForeignKey(d => d.EmployeeStatusId)
                    .HasConstraintName("FK_Entity_EmployeeStatus");

                entity.HasOne(d => d.IdnumberTypeNavigation)
                    .WithMany(p => p.Entities)
                    .HasForeignKey(d => d.IdnumberType)
                    .HasConstraintName("FK_Entity_IDNumberType");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.Entities)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK_Entity_MaritalStatus");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.Entities)
                    .HasForeignKey(d => d.TitleId)
                    .HasConstraintName("FK_Entity_TitleDescription");
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.ToTable("ErrorLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateLogged).HasColumnType("datetime");

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("Gender");

                entity.HasIndex(e => e.Code, "IX_Gender")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.LongDescription)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoryPayrollRun>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");
            });

            modelBuilder.Entity<IdnumberType>(entity =>
            {
                entity.ToTable("IDNumberType");

                entity.HasIndex(e => e.Idcode, "IX_IDNumberType")
                    .IsUnique();

                entity.Property(e => e.IdnumberTypeId).HasColumnName("IDNumberTypeID");

                entity.Property(e => e.Idcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDCode");

                entity.Property(e => e.LongDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IncreaseHistory>(entity =>
            {
                entity.ToTable("IncreaseHistory");

                entity.Property(e => e.IncreaseHistoryId).HasColumnName("IncreaseHistoryID");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.IncreaseAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.IncreaseAppliedOn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IncreasePercentage).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IncreaseProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.IncreaseReasonTypeId).HasColumnName("IncreaseReasonTypeID");

                entity.Property(e => e.JobGradeId).HasColumnName("JobGradeID");

                entity.Property(e => e.JobTitleId).HasColumnName("JobTitleID");

                entity.Property(e => e.LastChanged).HasColumnType("datetime");

                entity.Property(e => e.NewAnnualSalary).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.NewMonthlySalary).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.NewRatePerDay).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.NewRatePerHour).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PreviousAnnualSalary).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PreviousMonthlySalary).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PreviousRatePerDay).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PreviousRatePerHour).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ProcessedByUserId).HasColumnName("ProcessedByUserID");
            });

            modelBuilder.Entity<IncreaseReason>(entity =>
            {
                entity.ToTable("IncreaseReason");

                entity.HasIndex(e => e.Code, "IX_IncreaseReason")
                    .IsUnique();

                entity.Property(e => e.IncreaseReasonId).HasColumnName("IncreaseReasonID");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastChanged).HasColumnType("datetime");

                entity.Property(e => e.LongDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<JobGeneral>(entity =>
            {
                entity.ToTable("JobGeneral");

                entity.Property(e => e.JobGeneralId).HasColumnName("JobGeneralID");

                entity.Property(e => e.LongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JobGrade>(entity =>
            {
                entity.ToTable("JobGrade");

                entity.HasIndex(e => e.JobGradeCode, "IX_JobGrade")
                    .IsUnique();

                entity.Property(e => e.JobGradeId).HasColumnName("JobGradeID");

                entity.Property(e => e.JobGradeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JobGradeDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JobTitle>(entity =>
            {
                entity.ToTable("JobTitle");

                entity.HasIndex(e => e.Jobcode, "IX_JobTitle")
                    .IsUnique();

                entity.Property(e => e.ChangedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Jobcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastChanged).HasColumnType("datetime");

                entity.Property(e => e.LongDescription).IsUnicode(false);

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.JobGrade)
                    .WithMany(p => p.JobTitles)
                    .HasForeignKey(d => d.JobGradeId)
                    .HasConstraintName("FK_JobTitle_JobGrade");
            });

            modelBuilder.Entity<LeaveDetail>(entity =>
            {
                entity.ToTable("LeaveDetail");

                entity.Property(e => e.LeaveAccrualStartDate).HasColumnType("date");

                entity.Property(e => e.LeaveBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MonetaryEquivalent).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LeaveDetails)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeaveDetail_Employee");
            });

            modelBuilder.Entity<LeaveEntitlementView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LeaveEntitlementView");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveAccrualStartDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LeaveTypeDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MonetaryValue).HasColumnType("decimal(38, 6)");
            });

            modelBuilder.Entity<LeaveTransaction>(entity =>
            {
                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateApplied).HasColumnType("date");

                entity.Property(e => e.DateApproved).HasColumnType("date");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveEndDate).HasColumnType("date");

                entity.Property(e => e.LeaveStartDate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LeaveType>(entity =>
            {
                entity.HasIndex(e => e.Code, "IX_LeaveTypes")
                    .IsUnique();

                entity.Property(e => e.ApplicableGender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BalanceBroughtForwardOption)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cycle)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.LeaveTypeDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaritalStatus>(entity =>
            {
                entity.ToTable("MaritalStatus");

                entity.Property(e => e.LongDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NapsaConfiguration>(entity =>
            {
                entity.ToTable("NapsaConfiguration");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.MaximumCeiling).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.Percentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<NatureOfContract>(entity =>
            {
                entity.ToTable("NatureOfContract");

                entity.HasIndex(e => e.ContractTypeCode, "IX_NatureOfContract")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContractTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContractTypeDecsription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NhimaConfiguration>(entity =>
            {
                entity.ToTable("NhimaConfiguration");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Percentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<PayrollDeductionDef>(entity =>
            {
                entity.HasKey(e => e.DefId);

                entity.ToTable("PayrollDeductionDef");

                entity.HasIndex(e => e.DeductionCode, "IX_PayrollDeductionDef")
                    .IsUnique();

                entity.Property(e => e.DefId).HasColumnName("DefID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DeductionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeductionDecsription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Formula)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayrollEarningDef>(entity =>
            {
                entity.HasKey(e => e.DefId);

                entity.ToTable("PayrollEarningDef");

                entity.HasIndex(e => e.EarningLineCode, "IX_PayrollEarningDef")
                    .IsUnique();

                entity.Property(e => e.DefId).HasColumnName("DefID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.EarningLineCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EarningLineDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Formula)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayrollLinesFrequecyCode>(entity =>
            {
                entity.HasIndex(e => e.Code, "IX_PayrollLinesFrequecyCodes")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayrollRunDetailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PayrollRunDetailsView");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BasicPay).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateEngaged)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobGeneral)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JobGrade)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle).IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayslipDefinition>(entity =>
            {
                entity.HasKey(e => e.PayslipDefId);

                entity.ToTable("PayslipDefinition");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OccurenceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PayrollDefinitionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodEndDate).HasColumnType("date");

                entity.Property(e => e.PeriodStartDate).HasColumnType("date");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PayslipDefinitions)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayslipDefinition_Employee");

                entity.HasOne(d => d.OccurenceCodeNavigation)
                    .WithMany(p => p.PayslipDefinitions)
                    .HasPrincipalKey(p => p.Code)
                    .HasForeignKey(d => d.OccurenceCode)
                    .HasConstraintName("FK_PayslipDefinition_PayrollLinesFrequecyCodes");
            });

            modelBuilder.Entity<PayslipDetail>(entity =>
            {
                entity.HasKey(e => e.PayslipId);

                entity.ToTable("PayslipDetail");

                entity.Property(e => e.DeductionAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EarningAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PayPeriod).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<PayslipDetailArchive>(entity =>
            {
                entity.HasKey(e => e.PayslipArchiveId);

                entity.ToTable("PayslipDetailArchive");

                entity.Property(e => e.PayslipArchiveId).HasColumnName("PayslipArchiveID");

                entity.Property(e => e.DeductionAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.DeductionDefId).HasColumnName("DeductionDefID");

                entity.Property(e => e.EarningAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EarningDefId).HasColumnName("EarningDefID");

                entity.Property(e => e.EmpoyeeId).HasColumnName("EmpoyeeID");

                entity.Property(e => e.ExportDate).HasColumnType("datetime");

                entity.Property(e => e.ExportedByUserId).HasColumnName("ExportedByUserID");

                entity.Property(e => e.PayPeriod).HasColumnType("datetime");
            });

            modelBuilder.Entity<PositionCodesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PositionCodesView");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(201)
                    .IsUnicode(false);

                entity.Property(e => e.JobGrade)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitleCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PositionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReportsToPosition)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PositionDetail>(entity =>
            {
                entity.HasKey(e => e.PositionCodeId);

                entity.HasIndex(e => e.PositionCode, "IX_PositionDetails")
                    .IsUnique();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitleCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PositionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReportsToPositionCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VacancyDate).HasColumnType("datetime");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.PositionDetails)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PositionDetails_Department");

                entity.HasOne(d => d.JobTitleCodeNavigation)
                    .WithMany(p => p.PositionDetails)
                    .HasPrincipalKey(p => p.Jobcode)
                    .HasForeignKey(d => d.JobTitleCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PositionDetails_JobTitle");
            });

            modelBuilder.Entity<PromotionHistory>(entity =>
            {
                entity.ToTable("PromotionHistory");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NewPositionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OldPositionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PromotionDate).HasColumnType("date");
            });

            modelBuilder.Entity<Reference>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("reference");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Reference1)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("reference");
            });

            modelBuilder.Entity<StatusDescription>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK_GeneralStatusDescription");

                entity.ToTable("StatusDescription");

                entity.HasIndex(e => e.StatusId, "IX_GeneralStatusDescription")
                    .IsUnique();

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StausDescription)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SupplierRegAttachment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Supplier_RegAttachment");

                entity.Property(e => e.Attachment)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("attachment");

                entity.Property(e => e.AttachmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("attachmentType");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<SupplierRegistation>(entity =>
            {
                entity.ToTable("SupplierRegistation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyRegistrationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("companyRegistrationNumber");

                entity.Property(e => e.CompanyStatusNapsa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("companyStatusNapsa");

                entity.Property(e => e.CompanyStatusZra)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("companyStatusZRA");

                entity.Property(e => e.ConfirmationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("confirmationCode");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.CountryOfRegistration)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("countryOfRegistration");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.OrganizationName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("organizationName");

                entity.Property(e => e.OrganizationType)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("organizationType");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Shareholders)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("shareholders");

                entity.Property(e => e.SupplierRegistrationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplierRegistrationCode");

                entity.Property(e => e.Tpin)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TPIN");
            });

            modelBuilder.Entity<TaxTableDefinition>(entity =>
            {
                entity.ToTable("TaxTableDefinition");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BandDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.LowerLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UperLimit).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TerminationReason>(entity =>
            {
                entity.ToTable("TerminationReason");

                entity.HasIndex(e => e.Code, "IX_TerminationReason")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TitleDescription>(entity =>
            {
                entity.HasKey(e => e.TitleId);

                entity.ToTable("TitleDescription");

                entity.Property(e => e.TitleDescription1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TitleDescription");
            });

            modelBuilder.Entity<UserAuditLog>(entity =>
            {
                entity.HasKey(e => e.AuditId);

                entity.Property(e => e.AuditId).HasColumnName("AuditID");

                entity.Property(e => e.Action).IsUnicode(false);

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Guid)
                    .IsUnicode(false)
                    .HasColumnName("GUID");

                entity.Property(e => e.NewValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OldValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("UserDetail");

                entity.HasIndex(e => e.EmployeId, "IX_UserDetail")
                    .IsUnique();

                entity.HasIndex(e => e.Username, "IX_UserDetail_1")
                    .IsUnique();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastLogon).HasColumnType("datetime");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProfileStatusNavigation)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.ProfileStatus)
                    .HasConstraintName("FK_UserDetail_UserStatus");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("FK_UserDetail_UserRoles");
            });

            modelBuilder.Entity<UserMenu>(entity =>
            {
                entity.ToTable("UserMenu");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MenuDescription).IsUnicode(false);
            });

            modelBuilder.Entity<UserMenuMapping>(entity =>
            {
                entity.ToTable("UserMenuMapping");

                entity.Property(e => e.UserMenuMappingId).HasColumnName("UserMenuMappingID");

                entity.Property(e => e.UserMenuId).HasColumnName("UserMenuID");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.HasOne(d => d.UserMenu)
                    .WithMany(p => p.UserMenuMappings)
                    .HasForeignKey(d => d.UserMenuId)
                    .HasConstraintName("FK_UserMenuMapping_UserMenu");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.UserMenuMappings)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("FK_UserMenuMapping_UserRoles");
            });

            modelBuilder.Entity<UserPasswordReset>(entity =>
            {
                entity.HasKey(e => e.ResetId);

                entity.HasIndex(e => e.ResetId, "IX_UserPasswordResets");

                entity.HasIndex(e => e.ResetId, "IX_UserPasswordResets_1");

                entity.Property(e => e.ResetId).HasColumnName("ResetID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResetDate).HasColumnType("datetime");

                entity.Property(e => e.ResetToken).IsUnicode(false);

                entity.Property(e => e.TokenStatusId).HasColumnName("TokenStatusID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPasswordResets)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserPasswordResets_UserDetail");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.RoleDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("UserStatus");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
