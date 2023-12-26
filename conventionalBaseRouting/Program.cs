var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=home}/{Action=Index}/{id?}"
    );
//app.MapGet("/", () => "Hello World!");

app.Run();

//Routing is 2 types

// Conventional Base Routing => this is example of conventional based routing. in this code is applied on programe.cs 
 
// Attribute Base Routing
