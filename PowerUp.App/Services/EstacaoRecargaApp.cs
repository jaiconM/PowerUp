using PowerUp.App.Interfaces;
using PowerUp.Domain.Core.Entidades;
using PowerUp.Domain.Core.Interfaces;

namespace PowerUp.App.Services
{
    public class EstacaoRecargaApp : IEstacaoRecargaApp
    {
        private readonly IEstacaoRecargaService _estacaoRecargaService;

        public EstacaoRecargaApp(IEstacaoRecargaService estacaoRecargaService)
        {
            _estacaoRecargaService = estacaoRecargaService;
        }

        public IReadOnlyList<EstacaoRecarga> ListarTodos()
        {
            return _estacaoRecargaService.ListarTodos();
        }
        public void Adicionar(EstacaoRecarga estacaoRecarga)
        {
            _estacaoRecargaService.Adicionar(estacaoRecarga);
        }

        public void Atualizar(EstacaoRecarga estacaoRecarga)
        {
            _estacaoRecargaService.Atualizar(estacaoRecarga);
        }

        public void Excluir(EstacaoRecarga estacaoRecarga)
        {
            _estacaoRecargaService.Excluir(estacaoRecarga);
        }

        public EstacaoRecarga RecuperarPorId(Guid id)
        {
            return _estacaoRecargaService.RecuperarPorId(id);
        }
    }
}