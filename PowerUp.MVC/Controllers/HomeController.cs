using Microsoft.AspNetCore.Mvc;
using PowerUp.App.Interfaces;
using PowerUp.Domain.Core.Enums;
using PowerUp.MVC.Models;
using System.Diagnostics;

namespace PowerUp.MVC.Controllers
{
    public class HomeController : Controller
    {
        private const string IconeTipoMovel = "http://maps.google.com/mapfiles/ms/icons/blue-dot.png";
        private const string IconeTipoVeicular = "http://maps.google.com/mapfiles/ms/icons/green-dot.png";
        private readonly IEstacaoRecargaApp _estacaoRecargaApp;

        public HomeController(IEstacaoRecargaApp estacaoRecargaApp)
        {
            _estacaoRecargaApp = estacaoRecargaApp;
        }

        public IActionResult Index()
        {
            var estacoesDeRecarga = _estacaoRecargaApp.ListarTodos();
            var model = new List<EstacoesDeCargaViewModel>();
            foreach (var estacao in estacoesDeRecarga)
            {
                model.Add(
                    new EstacoesDeCargaViewModel
                    {
                        Icone = estacao.Tipo == Tipo.Veicular ? IconeTipoVeicular : IconeTipoMovel,
                        Titulo = $"{estacao.Nome} (Tipo: {estacao.Tipo})",
                        Latitude = estacao.Latitude.ToString().Replace(',','.'),
                        Longitude = estacao.Longitude.ToString().Replace(',', '.')
                    }
                );
            }
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}