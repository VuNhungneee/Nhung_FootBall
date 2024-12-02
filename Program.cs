using Microsoft.EntityFrameworkCore;
using Nhung_FootBall.Models;
using Nhung_FootBall.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("QlgiaiBongDaKiemTraContext");
builder.Services.AddDbContext<QlgiaiBongDaKiemTraContext>(x=>x.UseSqlServer(connectionString));

builder.Services.AddScoped<ITrongTaiRepository, TrongTaiRepository>();


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

app.Run();
