using Core.Interfaces;
using Core.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IExcelDataService, ExcelDataService>();
builder.Services.AddScoped<IProcurementPlanDataService, ProcurementPlanDataService>();
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
/*
    app.UseMvc(routes =>
    {
        routes.MapRoute(
            "default",
            "{controller=Home}/{action=Index}/{id?}");

        // --- Check this route exists ---
        routes.MapRoute(
            "areas",
            "{area:exists}/{controller=Home}/{action=Index}/{id?}");
    });*/
app.Run();