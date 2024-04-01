using Grading_App_Section_1.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Added Reed 3/29
builder.Services.AddDbContext<GradingAppContext>(options =>
{
    options.UseSqlite(builder.Configuration["ConnectionStrings:GradingAppConnection"]);
});
builder.Services.AddScoped<IGradingAppRepository, EFGradingAppRepository>();

builder.Services.AddHeroicons(builder.Configuration);





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