var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//=>>>>>>>>>>>>>>>>>>>>>>>>>>>> To add session add a services
builder.Services.AddSession();

// =>>>>>>>>>>>>>>>>>>>>>>>> To get session in view page
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


// =>>>>>>>>>>>>>>>>>>>>>>>>> to add automatic time out of session
builder.Services.AddSession(opt => {
    opt.IdleTimeout = TimeSpan.FromMinutes(1);
}) ;

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
