var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// to use routing u need to add routing middleware useRouting
//after that call USEEndPoints method to define your enpoint such as MapGet MapPost MapPut MapDelete
app.UseRouting();
//app.MapGet("/", () => "Hello World!");

//mapping routing method 
//1.mapGet
//2.mapPOST
//3.mapPut
//4.mapDelete

//app.UseEndpoints(endpoints => {

//    endpoints.MapGet("/Home", async (con) =>{
//        await con.Response.WriteAsync("this is the data ");
//    })
//    }); 
//this blog test with postman working fine
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (con) =>
    {
        await con.Response.WriteAsync("this is Home Request comming From Get");
    });
    endpoints.MapPost("/Home", async (con) =>
    {
        await con.Response.WriteAsync("this is Home Request comming From Post");
    }); endpoints.MapPut("/Home", async (con) =>
    {
        await con.Response.WriteAsync("this is Home Request comming From Put");
    }); endpoints.MapDelete("/Home", async (con) =>
    {
        await con.Response.WriteAsync("this is Home Request comming From Delete");
    });
});
//this blog test with postman working fine

//without UseRouting running the functions

//app.MapGet("/Home", () => "Get Request");
//app.MapPost("/Home", () => "Get Post");
//app.MapPut("/Home", () => "Get Put");
//app.MapDelete("/Home", () => "Get Delete");



app.Run();
