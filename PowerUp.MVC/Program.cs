var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

PowerUp.MVC.Config.MvcServiceCollectionExtensions.ConfigureIoC(builder.Services);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

PowerUp.MVC.Config.ApplicationBuilderExtensions.DefinaIdioma(app);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
