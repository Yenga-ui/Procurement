using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;





// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
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

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<BankBranch> BankBranch { get; set; }
        public virtual DbSet<CdfAdmin> CdfAdmin { get; set; }
        public virtual DbSet<CdfAsset> CdfAsset { get; set; }
        public virtual DbSet<CdfAssetType> CdfAssetType { get; set; }
        public virtual DbSet<CdfBid> CdfBid { get; set; }
        public virtual DbSet<CdfBudget> CdfBudget { get; set; }
        public virtual DbSet<CdfBudgetExpense> CdfBudgetExpense { get; set; }
        public virtual DbSet<CdfBudgetPeriod> CdfBudgetPeriod { get; set; }
        public virtual DbSet<CdfBudgetRevenue> CdfBudgetRevenue { get; set; }
        public virtual DbSet<CdfCompanyType> CdfCompanyType { get; set; }
        public virtual DbSet<CdfConstituency> CdfConstituency { get; set; }
        public virtual DbSet<CdfConstituency1> CdfConstituency1 { get; set; }
        public virtual DbSet<CdfDepartment> CdfDepartment { get; set; }
        public virtual DbSet<CdfEvaluationmethod> CdfEvaluationmethod { get; set; }
        public virtual DbSet<CdfExpenseType> CdfExpenseType { get; set; }
        public virtual DbSet<CdfFund> CdfFund { get; set; }
        public virtual DbSet<CdfFund1> CdfFund1 { get; set; }
        public virtual DbSet<CdfIdentityType> CdfIdentityType { get; set; }
        public virtual DbSet<CdfIdentityType1> CdfIdentityType1 { get; set; }
        public virtual DbSet<CdfLevels> CdfLevels { get; set; }
        public virtual DbSet<CdfOrganization> CdfOrganization { get; set; }
        public virtual DbSet<CdfOrganization1> CdfOrganization1 { get; set; }
        public virtual DbSet<CdfOrganizationActivation> CdfOrganizationActivation { get; set; }
        public virtual DbSet<CdfOrganizationbranches> CdfOrganizationbranches { get; set; }
        public virtual DbSet<CdfOrganizationdepartments> CdfOrganizationdepartments { get; set; }
        public virtual DbSet<CdfOrganizationjobs> CdfOrganizationjobs { get; set; }
        public virtual DbSet<CdfOrganizationprofile> CdfOrganizationprofile { get; set; }
        public virtual DbSet<CdfPermission> CdfPermission { get; set; }
        public virtual DbSet<CdfPlanItems> CdfPlanItems { get; set; }
        public virtual DbSet<CdfProcPlan> CdfProcPlan { get; set; }
        public virtual DbSet<CdfProcurement> CdfProcurement { get; set; }
        public virtual DbSet<CdfProcurementEntity> CdfProcurementEntity { get; set; }
        public virtual DbSet<CdfProcurementEntityType> CdfProcurementEntityType { get; set; }
        public virtual DbSet<CdfRole> CdfRole { get; set; }
        public virtual DbSet<CdfRoles> CdfRoles { get; set; }
        public virtual DbSet<CdfRoles1> CdfRoles1 { get; set; }
        public virtual DbSet<CdfServices> CdfServices { get; set; }
        public virtual DbSet<CdfStatus> CdfStatus { get; set; }
        public virtual DbSet<CdfStatus1> CdfStatus1 { get; set; }
        public virtual DbSet<CdfStock> CdfStock { get; set; }
        public virtual DbSet<CdfSupplierFee> CdfSupplierFee { get; set; }
        public virtual DbSet<CdfSupplierResDocuments> CdfSupplierResDocuments { get; set; }
        public virtual DbSet<CdfSupplierResponse> CdfSupplierResponse { get; set; }
        public virtual DbSet<CdfSupplierTenderPayment> CdfSupplierTenderPayment { get; set; }
        public virtual DbSet<CdfTender> CdfTender { get; set; }
        public virtual DbSet<CdfTenderCategory> CdfTenderCategory { get; set; }
        public virtual DbSet<CdfTenderProcedure> CdfTenderProcedure { get; set; }
        public virtual DbSet<CdfTenderSection> CdfTenderSection { get; set; }
        public virtual DbSet<CdfTenderSectionSub> CdfTenderSectionSub { get; set; }
        public virtual DbSet<CdfUser> CdfUser { get; set; }
        public virtual DbSet<CdfUser1> CdfUser1 { get; set; }
        public virtual DbSet<CdfUserType> CdfUserType { get; set; }
        public virtual DbSet<CdfUserType1> CdfUserType1 { get; set; }
        public virtual DbSet<CdfUsers> CdfUsers { get; set; }
        public virtual DbSet<CeecCategory> CeecCategory { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CountryNames> CountryNames { get; set; }
        public virtual DbSet<CurrencySymbol> CurrencySymbol { get; set; }
        public virtual DbSet<CurrencySymbol1> CurrencySymbol1 { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DisciplinaryCases> DisciplinaryCases { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeBankDetails> EmployeeBankDetails { get; set; }
        public virtual DbSet<EmployeeBankDetailsView> EmployeeBankDetailsView { get; set; }
        public virtual DbSet<EmployeeDetail> EmployeeDetail { get; set; }
        public virtual DbSet<EmployeeHistory> EmployeeHistory { get; set; }
        public virtual DbSet<EmployeeQualifications> EmployeeQualifications { get; set; }
        public virtual DbSet<EmployeeQualificationsView> EmployeeQualificationsView { get; set; }
        public virtual DbSet<EmployeeRemuneration> EmployeeRemuneration { get; set; }
        public virtual DbSet<EmployeeStatus> EmployeeStatus { get; set; }
        public virtual DbSet<EmployeeTimeSheet> EmployeeTimeSheet { get; set; }
        public virtual DbSet<Entity> Entity { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<HistoryPayrollRuns> HistoryPayrollRuns { get; set; }
        public virtual DbSet<IdnumberType> IdnumberType { get; set; }
        public virtual DbSet<IncreaseHistory> IncreaseHistory { get; set; }
        public virtual DbSet<IncreaseReason> IncreaseReason { get; set; }
        public virtual DbSet<JobGeneral> JobGeneral { get; set; }
        public virtual DbSet<JobGrade> JobGrade { get; set; }
        public virtual DbSet<JobTitle> JobTitle { get; set; }
        public virtual DbSet<LeaveDetail> LeaveDetail { get; set; }
        public virtual DbSet<LeaveEntitlementView> LeaveEntitlementView { get; set; }
        public virtual DbSet<LeaveTransactions> LeaveTransactions { get; set; }
        public virtual DbSet<LeaveTypes> LeaveTypes { get; set; }
        public virtual DbSet<MaritalStatus> MaritalStatus { get; set; }
        public virtual DbSet<NapsaConfiguration> NapsaConfiguration { get; set; }
        public virtual DbSet<NatureOfContract> NatureOfContract { get; set; }
        public virtual DbSet<NhimaConfiguration> NhimaConfiguration { get; set; }
        public virtual DbSet<PayrollDeductionDef> PayrollDeductionDef { get; set; }
        public virtual DbSet<PayrollEarningDef> PayrollEarningDef { get; set; }
        public virtual DbSet<PayrollLinesFrequecyCodes> PayrollLinesFrequecyCodes { get; set; }
        public virtual DbSet<PayrollRunDetailsView> PayrollRunDetailsView { get; set; }
        public virtual DbSet<PayslipDefinition> PayslipDefinition { get; set; }
        public virtual DbSet<PayslipDetail> PayslipDetail { get; set; }
        public virtual DbSet<PayslipDetailArchive> PayslipDetailArchive { get; set; }
        public virtual DbSet<PositionCodesView> PositionCodesView { get; set; }
        public virtual DbSet<PositionDetails> PositionDetails { get; set; }
        public virtual DbSet<PromotionHistory> PromotionHistory { get; set; }
        public virtual DbSet<Reference> Reference { get; set; }
        public virtual DbSet<StatusDescription> StatusDescription { get; set; }
        public virtual DbSet<SupplierRegAttachment> SupplierRegAttachment { get; set; }
        public virtual DbSet<SupplierRegistation> SupplierRegistation { get; set; }
        public virtual DbSet<TaxTableDefinition> TaxTableDefinition { get; set; }
        public virtual DbSet<TerminationReason> TerminationReason { get; set; }
        public virtual DbSet<TitleDescription> TitleDescription { get; set; }
        public virtual DbSet<UserAuditLogs> UserAuditLogs { get; set; }
        public virtual DbSet<UserDetail> UserDetail { get; set; }
        public virtual DbSet<UserMenu> UserMenu { get; set; }
        public virtual DbSet<UserMenuMapping> UserMenuMapping { get; set; }
        public virtual DbSet<UserPasswordResets> UserPasswordResets { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<UserStatus> UserStatus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=HQ-IPM-CBUM03;Database=MyPayroll;persist security info=True;user id=sa;password=Srax200plus;;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("IX_Bank")
                    .IsUnique();

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
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

                entity.HasIndex(e => e.BranchCode)
                    .HasName("IX_BankBranch")
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
                    .WithMany(p => p.BankBranch)
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
                    .HasColumnName("asset")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AssetType)
                    .HasColumnName("asset_type")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CdfAssetType>(entity =>
            {
                entity.ToTable("CDF_AssetType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssetType)
                    .HasColumnName("assetType")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CdfBid>(entity =>
            {
                entity.ToTable("CDF_Bid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Details)
                    .HasColumnName("details")
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId).HasColumnName("supplierID");

                entity.Property(e => e.TenderId).HasColumnName("tenderID");
            });

            modelBuilder.Entity<CdfBudget>(entity =>
            {
                entity.ToTable("CDF_Budget");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BudgetName)
                    .HasColumnName("budgetName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetYear).HasColumnName("budgetYear");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Period)
                    .HasColumnName("period")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfBudgetExpense>(entity =>
            {
                entity.ToTable("CDF_BudgetExpense");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .IsRequired()
                    .HasColumnName("amount")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetId).HasColumnName("budget_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasColumnName("currency")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfBudgetPeriod>(entity =>
            {
                entity.ToTable("CDF_BudgetPeriod");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BudgetId).HasColumnName("budget_id");

                entity.Property(e => e.Period)
                    .HasColumnName("period")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfBudgetRevenue>(entity =>
            {
                entity.ToTable("CDF_BudgetRevenue");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetId).HasColumnName("budget_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Currency)
                    .HasColumnName("currency")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);
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
                    .HasColumnName("constituency")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(50)
                    .IsUnicode(false);
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
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfEvaluationmethod>(entity =>
            {
                entity.ToTable("CDF_EVALUATIONMETHOD");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Method)
                    .HasColumnName("method")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfExpenseType>(entity =>
            {
                entity.ToTable("CDF_ExpenseType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExpenseType)
                    .HasColumnName("expenseType")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfFund>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CDF_Fund");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Currency)
                    .HasColumnName("currency")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fund)
                    .HasColumnName("fund")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();
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
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfIdentityType1>(entity =>
            {
                entity.ToTable("CdfIdentityType");
            });

            modelBuilder.Entity<CdfLevels>(entity =>
            {
                entity.ToTable("CDF_Levels");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LevelInOrganization).HasColumnName("levelInOrganization");

                entity.Property(e => e.NumberOfUsers).HasColumnName("numberOfUsers");
            });

            modelBuilder.Entity<CdfOrganization>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("CDF_ORGANIZATION");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Activated)
                    .HasColumnName("activated")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FirstAdminEmail)
                    .HasColumnName("first_Admin_Email")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstAdminId)
                    .HasColumnName("first_Admin_ID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstAdminIdentityType)
                    .HasColumnName("first_Admin_Identity_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstAdminPhone)
                    .HasColumnName("first_Admin_Phone")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

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
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");
            });

            modelBuilder.Entity<CdfOrganizationbranches>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CDF_ORGANIZATIONBRANCHES");

                entity.Property(e => e.BranchAddress)
                    .HasColumnName("branchAddress")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branchName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CdfOrganizationdepartments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CDF_ORGANIZATIONDEPARTMENTS");

                entity.Property(e => e.DepartmentHeadJobId).HasColumnName("departmentHeadJobID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("departmentName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CdfOrganizationjobs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CDF_ORGANIZATIONJOBS");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrganizationGrade).HasColumnName("organization_grade");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.OrganizationLevel).HasColumnName("organization_level");

                entity.Property(e => e.OrganizationTitle)
                    .HasColumnName("organization_title")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Strength).HasColumnName("strength");
            });

            modelBuilder.Entity<CdfOrganizationprofile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CDF_ORGANIZATIONPROFILE");

                entity.Property(e => e.CompanyAddress)
                    .HasColumnName("companyAddress")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyEmail)
                    .HasColumnName("companyEmail")
                    .HasMaxLength(200)
                    .IsUnicode(false);

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
                    .HasColumnName("organization_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CdfPermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CDF_Permission");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Permission)
                    .HasColumnName("permission")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfPlanItems>(entity =>
            {
                entity.ToTable("CDF_PlanItems");

                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.Award).IsUnicode(false);

                entity.Property(e => e.Budget)
                    .HasColumnName("budget")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Class)
                    .HasColumnName("Class")
                    .IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Prequalification).IsUnicode(false);

                entity.Property(e => e.ProcPlanId).HasColumnName("procPlanID");

                entity.Property(e => e.ProcurementMethod)
                    .HasColumnName("procurementMethod")
                    .IsUnicode(false);

                entity.Property(e => e.ProjectCode)
                    .HasColumnName("ProjectCode")
                    .IsUnicode(false);

                entity.Property(e => e.Publication)
                    .HasColumnName("Publication")
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnName("Quantity");

                entity.Property(e => e.RefNo)
                    .HasColumnName("RefNo")
                    .IsUnicode(false);

                entity.Property(e => e.SourceOfFunds)
                    .HasColumnName("SourceOfFunds")
                    .IsUnicode(false);

                entity.Property(e => e.Start).HasColumnType("datetime");

            /*    entity.Property(e => e.TypeOfEntry)
                    .HasColumnName("TypeOfEntry")
                    .IsUnicode(false);
            */
                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("UnitOfMeasure")
                    .IsUnicode(false);

                entity.Property(e => e.Unspsc)
                    .HasColumnName("Unspsc")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfProcPlan>(entity =>
            {
                entity.ToTable("CDF_ProcPlan");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .IsUnicode(false);

                entity.Property(e => e.EntityId).HasColumnName("entityID");

                entity.Property(e => e.Modified)
                    .HasColumnName("modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfProcurement>(entity =>
            {
                entity.ToTable("CDF_Procurement");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Method)
                    .HasColumnName("method")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfBidders).HasColumnName("numberOfBidders");
            });

            modelBuilder.Entity<CdfProcurementEntity>(entity =>
            {
                entity.ToTable("CDF_ProcurementEntity");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .IsUnicode(false);

                entity.Property(e => e.EntityName)
                    .HasColumnName("entityName")
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfProcurementEntityType>(entity =>
            {
                entity.ToTable("CDF_ProcurementEntityType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfRole>(entity =>
            {
                entity.ToTable("CDF_Role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LevelId).HasColumnName("levelID");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfRoles>(entity =>
            {
                entity.ToTable("CDF_Roles");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<CdfRoles1>(entity =>
            {
                entity.ToTable("CdfRoles");
            });

            modelBuilder.Entity<CdfServices>(entity =>
            {
                entity.ToTable("CDF_Services");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Service)
                    .HasColumnName("service")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CDF_Status");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);
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
                    .HasColumnName("createdBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Stock)
                    .HasColumnName("stock")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StockCode)
                    .HasColumnName("stockCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfSupplierFee>(entity =>
            {
                entity.ToTable("CDF_SupplierFee");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SupplierFee).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<CdfSupplierResDocuments>(entity =>
            {
                entity.ToTable("Cdf_Supplier_ResDocuments");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .IsUnicode(false);

                entity.Property(e => e.SectionId).HasColumnName("section_id");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfSupplierResponse>(entity =>
            {
                entity.ToTable("Cdf_Supplier_Response");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SectionId).HasColumnName("section_id");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.TenderId).HasColumnName("tender_id");

                entity.Property(e => e.TextResponse)
                    .HasColumnName("text_response")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<CdfSupplierTenderPayment>(entity =>
            {
                entity.ToTable("CDF_SupplierTenderPayment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Paid).HasColumnName("paid");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplierCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenderCode)
                    .HasColumnName("tenderCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfTender>(entity =>
            {
                entity.ToTable("CDF_Tender");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BudgetExpenseId).HasColumnName("budget_expense_id");

                entity.Property(e => e.BudgetId).HasColumnName("budget_id");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .IsUnicode(false);

                entity.Property(e => e.ClarificationDeadline)
                    .HasColumnName("clarificationDeadline")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractNoticeDate)
                    .HasColumnName("contractNoticeDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate)
                    .HasColumnName("dueDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EvaluationMechanism)
                    .HasColumnName("evaluationMechanism")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvitationDate)
                    .HasColumnName("invitationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LongDescription)
                    .HasColumnName("longDescription")
                    .IsUnicode(false);

                entity.Property(e => e.ShortDescription)
                    .HasColumnName("shortDescription")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Submission')");

                entity.Property(e => e.SubmissionDeadline)
                    .HasColumnName("submissionDeadline")
                    .HasColumnType("datetime");

                entity.Property(e => e.TenderProcedure)
                    .HasColumnName("tenderProcedure")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TenderProcurementTechnique)
                    .HasColumnName("tenderProcurementTechnique")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TenderSerial)
                    .HasColumnName("tenderSerial")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Units)
                    .HasColumnName("units")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfTenderCategory>(entity =>
            {
                entity.ToTable("CDF_TenderCategory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uom)
                    .HasColumnName("uom")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfTenderProcedure>(entity =>
            {
                entity.ToTable("CDF_TenderProcedure");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NumberofBidders).HasColumnName("numberofBidders");

                entity.Property(e => e.TenderProcedure)
                    .HasColumnName("tenderProcedure")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfTenderSection>(entity =>
            {
                entity.ToTable("Cdf_TenderSection");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.SupportingDocumentation).HasColumnName("supporting_documentation");

                entity.Property(e => e.TenderId).HasColumnName("tenderID");

                entity.Property(e => e.TextResponse).HasColumnName("text_response");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfTenderSectionSub>(entity =>
            {
                entity.ToTable("CDF_TenderSectionSub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumberInput)
                    .HasColumnName("numberInput")
                    .IsUnicode(false);

                entity.Property(e => e.SupportingDocumentation)
                    .HasColumnName("supportingDocumentation")
                    .IsUnicode(false);

                entity.Property(e => e.TenderId).HasColumnName("tenderID");

                entity.Property(e => e.TenderSectionId).HasColumnName("tenderSectionID");

                entity.Property(e => e.TextResponse)
                    .HasColumnName("textResponse")
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfUser>(entity =>
            {
                entity.ToTable("CDF_User");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConsituencyId).HasColumnName("consituency_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailConfirmed).HasColumnName("emailConfirmed");

                entity.Property(e => e.Fname)
                    .HasColumnName("fname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasColumnName("lname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Logo).HasColumnName("logo");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcEntity)
                    .HasColumnName("procEntity")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfUser1>(entity =>
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
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdfUserType1>(entity =>
            {
                entity.ToTable("CdfUserType");
            });

            modelBuilder.Entity<CdfUsers>(entity =>
            {
                entity.ToTable("CDF_Users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logo).HasColumnName("logo");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .IsUnicode(false);

                entity.Property(e => e.ProcEntity)
                    .HasColumnName("procEntity")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CeecCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CEEC_CATEGORY");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.CompanyName).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");
            });

            modelBuilder.Entity<CountryNames>(entity =>
            {
                entity.HasIndex(e => e.CountryCode)
                    .HasName("IX_CountryNames")
                    .IsUnique();

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CurrencySymbol>(entity =>
            {
                entity.ToTable("Currency_Symbol");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnName("currency")
                    .HasMaxLength(39)
                    .IsUnicode(false);

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasColumnName("symbol")
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<CurrencySymbol1>(entity =>
            {
                entity.ToTable("CurrencySymbol");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasIndex(e => e.DepartmentCode)
                    .HasName("IX_Department")
                    .IsUnique();

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.ChangedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentCode)
                    .IsRequired()
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

            modelBuilder.Entity<DisciplinaryCases>(entity =>
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
                entity.Property(e => e.BidId).HasColumnName("bidID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileData).IsRequired();

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(250);

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
                entity.HasIndex(e => e.EmployeeCode)
                    .HasName("IX_Employee")
                    .IsUnique();

                entity.HasIndex(e => e.EntityId)
                    .HasName("IX_Employee_1")
                    .IsUnique();

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateEngaged).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
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
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Employee_Department");

                entity.HasOne(d => d.EmployeeStatus)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.EmployeeStatusId)
                    .HasConstraintName("FK_Employee_EmployeeStatus");

                entity.HasOne(d => d.Entity)
                    .WithOne(p => p.Employee)
                    .HasForeignKey<Employee>(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Entity");

                entity.HasOne(d => d.JobGeneral)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.JobGeneralId)
                    .HasConstraintName("FK_Employee_JobGeneral");

                entity.HasOne(d => d.JobGrade)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.JobGradeId)
                    .HasConstraintName("FK_Employee_JobGrade");

                entity.HasOne(d => d.JobTitle)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.JobTitleId)
                    .HasConstraintName("FK_Employee_JobTitle");

                entity.HasOne(d => d.NatureOfContract)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.NatureOfContractId)
                    .HasConstraintName("FK_Employee_NatureOfContract");

                entity.HasOne(d => d.TerminationReason)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.TerminationReasonId)
                    .HasConstraintName("FK_Employee_TerminationReason");
            });

            modelBuilder.Entity<EmployeeBankDetails>(entity =>
            {
                entity.HasIndex(e => e.AccountNumber)
                    .HasName("IX_EmployeeBankDetails")
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
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateEngaged)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idnumber)
                    .IsRequired()
                    .HasColumnName("IDNumber")
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
                    .IsRequired()
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

                entity.Property(e => e.PhysicalAddress)
                    .IsRequired()
                    .IsUnicode(false);

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
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateEngaged).HasColumnType("datetime");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PositionCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeQualifications>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.Property(e => e.DocumentContent).IsRequired();

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

                entity.Property(e => e.GuId)
                    .IsRequired()
                    .IsUnicode(false);

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

                entity.Property(e => e.DocumentContent).IsRequired();

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

                entity.Property(e => e.GuId)
                    .IsRequired()
                    .IsUnicode(false);

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
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeRemuneration)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeRemuneration_Employee");
            });

            modelBuilder.Entity<EmployeeStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.HasIndex(e => e.StatusCode)
                    .HasName("IX_EmployeeStatus")
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
                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateWorked).HasColumnType("date");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
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

                entity.HasIndex(e => e.Idnumber)
                    .HasName("IX_Entity")
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
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Idnumber)
                    .IsRequired()
                    .HasColumnName("IDNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdnumberType).HasColumnName("IDNumberType");

                entity.Property(e => e.LastChanged).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
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
                    .WithMany(p => p.Entity)
                    .HasForeignKey(d => d.CountryOfBirthId)
                    .HasConstraintName("FK_Entity_CountryNames");

                entity.HasOne(d => d.EmployeeStatus)
                    .WithMany(p => p.Entity)
                    .HasForeignKey(d => d.EmployeeStatusId)
                    .HasConstraintName("FK_Entity_EmployeeStatus");

                entity.HasOne(d => d.IdnumberTypeNavigation)
                    .WithMany(p => p.Entity)
                    .HasForeignKey(d => d.IdnumberType)
                    .HasConstraintName("FK_Entity_IDNumberType");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.Entity)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK_Entity_MaritalStatus");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.Entity)
                    .HasForeignKey(d => d.TitleId)
                    .HasConstraintName("FK_Entity_TitleDescription");
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateLogged).HasColumnType("datetime");

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("IX_Gender")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.LongDescription)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoryPayrollRuns>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");
            });

            modelBuilder.Entity<IdnumberType>(entity =>
            {
                entity.ToTable("IDNumberType");

                entity.HasIndex(e => e.Idcode)
                    .HasName("IX_IDNumberType")
                    .IsUnique();

                entity.Property(e => e.IdnumberTypeId).HasColumnName("IDNumberTypeID");

                entity.Property(e => e.Idcode)
                    .HasColumnName("IDCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IncreaseHistory>(entity =>
            {
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
                entity.HasIndex(e => e.Code)
                    .HasName("IX_IncreaseReason")
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
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JobGeneral>(entity =>
            {
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
                entity.HasIndex(e => e.JobGradeCode)
                    .HasName("IX_JobGrade")
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
                entity.HasIndex(e => e.Jobcode)
                    .HasName("IX_JobTitle")
                    .IsUnique();

                entity.Property(e => e.ChangedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Jobcode)
                    .IsRequired()
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
                    .WithMany(p => p.JobTitle)
                    .HasForeignKey(d => d.JobGradeId)
                    .HasConstraintName("FK_JobTitle_JobGrade");
            });

            modelBuilder.Entity<LeaveDetail>(entity =>
            {
                entity.Property(e => e.LeaveAccrualStartDate).HasColumnType("date");

                entity.Property(e => e.LeaveBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MonetaryEquivalent).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LeaveDetail)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeaveDetail_Employee");
            });

            modelBuilder.Entity<LeaveEntitlementView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LeaveEntitlementView");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
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

            modelBuilder.Entity<LeaveTransactions>(entity =>
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

            modelBuilder.Entity<LeaveTypes>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("IX_LeaveTypes")
                    .IsUnique();

                entity.Property(e => e.ApplicableGender)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BalanceBroughtForwardOption)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
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
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaritalStatus>(entity =>
            {
                entity.Property(e => e.LongDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NapsaConfiguration>(entity =>
            {
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
                entity.HasIndex(e => e.ContractTypeCode)
                    .HasName("IX_NatureOfContract")
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

                entity.HasIndex(e => e.DeductionCode)
                    .HasName("IX_PayrollDeductionDef")
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

                entity.HasIndex(e => e.EarningLineCode)
                    .HasName("IX_PayrollEarningDef")
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

            modelBuilder.Entity<PayrollLinesFrequecyCodes>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("IX_PayrollLinesFrequecyCodes")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .IsRequired()
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
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdNumber)
                    .IsRequired()
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
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayslipDefinition>(entity =>
            {
                entity.HasKey(e => e.PayslipDefId);

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
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PayslipDefinition)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayslipDefinition_Employee");

                entity.HasOne(d => d.OccurenceCodeNavigation)
                    .WithMany(p => p.PayslipDefinition)
                    .HasPrincipalKey(p => p.Code)
                    .HasForeignKey(d => d.OccurenceCode)
                    .HasConstraintName("FK_PayslipDefinition_PayrollLinesFrequecyCodes");
            });

            modelBuilder.Entity<PayslipDetail>(entity =>
            {
                entity.HasKey(e => e.PayslipId);

                entity.Property(e => e.DeductionAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EarningAmount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PayPeriod).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<PayslipDetailArchive>(entity =>
            {
                entity.HasKey(e => e.PayslipArchiveId);

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
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PositionCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReportsToPosition)
                    .IsRequired()
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

            modelBuilder.Entity<PositionDetails>(entity =>
            {
                entity.HasKey(e => e.PositionCodeId);

                entity.HasIndex(e => e.PositionCode)
                    .HasName("IX_PositionDetails")
                    .IsUnique();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitleCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PositionCode)
                    .IsRequired()
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
                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NewPositionCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OldPositionCode)
                    .IsRequired()
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
                    .HasColumnName("reference")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StatusDescription>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK_GeneralStatusDescription");

                entity.HasIndex(e => e.StatusId)
                    .HasName("IX_GeneralStatusDescription")
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
                    .HasColumnName("attachment")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AttachmentType)
                    .HasColumnName("attachmentType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SupplierRegistation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyRegistrationNumber)
                    .HasColumnName("companyRegistrationNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyStatusNapsa)
                    .HasColumnName("companyStatusNapsa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyStatusZra)
                    .HasColumnName("companyStatusZRA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmationCode)
                    .HasColumnName("confirmationCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryOfRegistration)
                    .HasColumnName("countryOfRegistration")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationName)
                    .HasColumnName("organizationName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationType)
                    .HasColumnName("organizationType")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Paid).HasColumnName("paid");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Shareholders)
                    .HasColumnName("shareholders")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierRegistrationCode)
                    .HasColumnName("supplierRegistrationCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tpin)
                    .HasColumnName("TPIN")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaxTableDefinition>(entity =>
            {
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
                entity.HasIndex(e => e.Code)
                    .HasName("IX_TerminationReason")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TitleDescription>(entity =>
            {
                entity.HasKey(e => e.TitleId);

                entity.Property(e => e.TitleDescription1)
                    .HasColumnName("TitleDescription")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserAuditLogs>(entity =>
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
                    .HasColumnName("GUID")
                    .IsUnicode(false);

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

                entity.HasIndex(e => e.EmployeId)
                    .HasName("IX_UserDetail")
                    .IsUnique();

                entity.HasIndex(e => e.Username)
                    .HasName("IX_UserDetail_1")
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
                    .WithMany(p => p.UserDetail)
                    .HasForeignKey(d => d.ProfileStatus)
                    .HasConstraintName("FK_UserDetail_UserStatus");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.UserDetail)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("FK_UserDetail_UserRoles");
            });

            modelBuilder.Entity<UserMenu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MenuDescription).IsUnicode(false);
            });

            modelBuilder.Entity<UserMenuMapping>(entity =>
            {
                entity.Property(e => e.UserMenuMappingId).HasColumnName("UserMenuMappingID");

                entity.Property(e => e.UserMenuId).HasColumnName("UserMenuID");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.HasOne(d => d.UserMenu)
                    .WithMany(p => p.UserMenuMapping)
                    .HasForeignKey(d => d.UserMenuId)
                    .HasConstraintName("FK_UserMenuMapping_UserMenu");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.UserMenuMapping)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("FK_UserMenuMapping_UserRoles");
            });

            modelBuilder.Entity<UserPasswordResets>(entity =>
            {
                entity.HasKey(e => e.ResetId);

                entity.HasIndex(e => e.ResetId)
                    .HasName("IX_UserPasswordResets_1");

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

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => e.UserRoleId);

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.RoleDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

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
