using Microsoft.AspNetCore.Mvc;
using PowerUp.App.Interfaces;
using PowerUp.Domain.Core.Entidades;

namespace PowerUp.MVC.Controllers
{
    public class EstacoesRecargasController : Controller
    {
        private readonly IEstacaoRecargaApp _estacaoRecargaApp;

        public EstacoesRecargasController(IEstacaoRecargaApp estacaoRecargaApp)
        {
            _estacaoRecargaApp = estacaoRecargaApp;
        }

        public ActionResult Index()
        {
            return View(_estacaoRecargaApp.ListarTodos().OrderBy(estacao => estacao.Nome));
        }

        public ActionResult Details(Guid id)
        {
            return View(_estacaoRecargaApp.RecuperarPorId(id));
        }

        public ActionResult Create()
        {
            return View(new EstacaoRecarga());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EstacaoRecarga estacaoRecarga)
        {
            try
            {
                estacaoRecarga.Id = Guid.NewGuid();
                estacaoRecarga.DataCriacao = DateTime.Now;
                _estacaoRecargaApp.Adicionar(estacaoRecarga);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(Guid id)
        {
            return View(_estacaoRecargaApp.RecuperarPorId(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstacaoRecarga estacaoRecarga)
        {
            try
            {
                _estacaoRecargaApp.Atualizar(estacaoRecarga);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(Guid id)
        {
            return View(_estacaoRecargaApp.RecuperarPorId(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(EstacaoRecarga estacaoRecarga)
        {
            try
            {
                _estacaoRecargaApp.Excluir(estacaoRecarga);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
