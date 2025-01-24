using DatabaseOperations.Implimentations;
using DatabaseOperations.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add logging
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddDebug();

// Dependency Injection
builder.Services.AddScoped<ISchoolService, SchoolService>(provider =>
{
    return new SchoolService(builder.Configuration.GetConnectionString("School"));
});

builder.Services.AddScoped<ILevelService, LevelService>(provider =>
{
    return new LevelService(builder.Configuration.GetConnectionString("School"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
