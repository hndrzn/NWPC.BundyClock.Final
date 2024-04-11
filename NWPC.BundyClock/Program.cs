using Microsoft.EntityFrameworkCore;
using NWPC.BundyClock.Data;
using NWPC.BundyClock.Services;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IEmployeeServices, EmployeeService>();
builder.Services.AddScoped<EmployeeService>();
builder.Services.AddScoped<IBundyRecordsService, BundyRecordsService>();
builder.Services.AddSingleton<IBundyStateService, BundyStateService>();
builder.Services.AddMudServices();


// Configure the HTTP request pipeline.
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
