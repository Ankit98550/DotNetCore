//for db first approch hit a command

//Scaffold-DbContext "Server=DESKTOP-LI3L725\SQLEXPRESS;TrustServerCertificate=True;Database=test1;user ID=DESKTOP-LI3L725\Ankit;Integrated Security=True;MultipleActiveResultSets=true;Encrypt=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
//Update Db First Approch
//Scaffold-DbContext "Server=DESKTOP-LI3L725\SQLEXPRESS;TrustServerCertificate=True;Database=test1;user ID=DESKTOP-LI3L725\Ankit;Integrated Security=True;MultipleActiveResultSets=true;Encrypt=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force

using DBFirstApproch.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var provider=builder.Services.BuildServiceProvider();
var config=provider.GetRequiredService<IConfiguration>();
builder.Services.AddDbContext<Test1Context>(item=>item.UseSqlServer(config.GetConnectionString("dbcs")));


var app = builder.Build();

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
