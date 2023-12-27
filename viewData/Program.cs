var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(name: "defult", pattern: "{controller=User}/{action=index}/{id?}");
app.Run();
