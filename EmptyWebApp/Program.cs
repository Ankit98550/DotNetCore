var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//app.MapGet("/", () => "Hello World!");
app.Use(async (con,next) =>
{
    await con.Response.WriteAsync("Rohit here");
    await next(con);
});
app.Use(async (con,next) =>
{
    await con.Response.WriteAsync("Rohit here 1");
    await next(con);
});

app.Run(async (con) =>
{
    await con.Response.WriteAsync("Ankit kuta hai");
}
    );
app.Run();  

// sync chata hai jo phele dala wo phele 

//if you run() function taken at top it will excute first rest of codes not run

