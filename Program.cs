using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GBC_WebDevelopers.Data;
using GBC_WebDevelopers.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<GBC_WebDevelopersContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GBC_WebDevelopersContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// PRODUCTS
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

//TECHNICIANS

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    TechniciansData.Initialize(services);
}

//CUSTOMERS
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    CustomersData.Initialize(services);
}

//INCIDENTS
//CUSTOMERS
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    IncidentsData.Initialize(services);
}


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

app.Run();
