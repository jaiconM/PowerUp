using PowerUp.App.Interfaces;
using PowerUp.App.Services;
using PowerUp.Data.Repository;
using PowerUp.Domain.Core.Interfaces;
using PowerUp.Domain.Core.Servicos;

namespace PowerUp.MVC.Config
{
    public static class MvcServiceCollectionExtensions
    {
        public static void ConfigureIoC(this IServiceCollection services)
        {
            services.AddSingleton<IEstacaoRecargaApp, EstacaoRecargaApp>();
            services.AddSingleton<IEstacaoRecargaService, EstacaoRecargaService>();
            services.AddSingleton<IEstacaoRecargaRepository, EstacaoRecargaRepository>();
        }
    }
}
