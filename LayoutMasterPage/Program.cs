using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();    
var app = builder.Build();
app.UseStaticFiles();   
//app.MapGet("/", () => "Hello World!");

//app.MapControllers();
app.MapControllerRoute(name:"Default",
    pattern:"{Controller=Home}/{action=index}/{id?}");

app.Run();
