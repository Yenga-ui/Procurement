using Core.Interfaces;
using Core.Models;
using Core.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc()
      .AddSessionStateTempDataProvider();
builder.Services.AddSession();

builder.Configuration.SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", false, true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
    .AddEnvironmentVariables();

var connectionString = builder.Configuration.GetConnectionString("DBConnection");
builder.Services.AddDbContext<MyPayrollContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<IExcelDataService, ExcelDataService>();
builder.Services.AddScoped<IProcurementPlanDataService, ProcurementPlanDataService>();
builder.Services.AddScoped<IDropDownService, DropDownService>();
builder.Services.AddScoped<ITenderService, TenderService > ();
builder.Services.AddScoped<ITenderSectionDataService, TenderSectionDataService>();
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();

app.UseAuthorization();
app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TestConnectionString
{
    class Program
    {
        static void Main(string[] args)
        {
            using SqlConnection conn = new SqlConnection("Server=localhost;Database=MyPayroll;User Id=sa;Password=devOps2022;");
            conn.Open();

            Console.WriteLine("Connection is just opened");
            SqlCommand command = new SqlCommand("SELECT * FROM [MyPayroll].[dbo].[BankBranch]", conn);

            var connectionState = conn.State;

            SqlDataReader reader = command.ExecuteReader();

            // Call Read before accessing data.
            while (reader.Read())
            {
                ReadSingleRow((IDataRecord)reader);
            }

            // Call Close when done reading.
            reader.Close();
            System.Threading.Thread.Sleep(10000);
            conn.Close();
        }
        private static void ReadSingleRow(IDataRecord dataRecord)
        {
            if (dataRecord == null) return;
            var var1 = dataRecord[3];
            Console.WriteLine(String.Format("{0}, {1}",var1, dataRecord[1]));
        }
    }

}*/