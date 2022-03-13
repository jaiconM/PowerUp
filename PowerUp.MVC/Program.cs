using PowerUp.App.Interfaces;
using PowerUp.App.Services;
using PowerUp.Data.Repository;
using PowerUp.Domain.Core.Interfaces;
using PowerUp.Domain.Core.Servicos;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IEstacaoRecargaApp, EstacaoRecargaApp>();
builder.Services.AddSingleton<IEstacaoRecargaService, EstacaoRecargaService>();
builder.Services.AddSingleton<IEstacaoRecargaRepository, EstacaoRecargaRepository>();

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
