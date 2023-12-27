var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(name: "default", pattern: "{controller=home}/{action=Index}/{id?}"
    );

app.Run();
