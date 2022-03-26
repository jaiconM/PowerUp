using Microsoft.AspNetCore.Mvc;
using PowerUp.App.Interfaces;
using PowerUp.Domain.Core.Entidades;
using PowerUp.Domain.Core.Enums;
using PowerUp.MVC.Models;
using System.Diagnostics;

namespace PowerUp.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEstacaoRecargaApp _estacaoRecargaApp;

        public HomeController(IEstacaoRecargaApp estacaoRecargaApp)
        {
            _estacaoRecargaApp = estacaoRecargaApp;
        }

        public IActionResult Index()
        {
            var estacoesDeRecarga = _estacaoRecargaApp.ListarTodos();

            var model = new MapaViewModel(estacoesDeRecarga);

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}