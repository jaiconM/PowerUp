using PowerUp.Domain.Core.Entidades;
using PowerUp.Domain.Core.Interfaces;

namespace PowerUp.Domain.Core.Servicos
{
    public class EstacaoRecargaService : IEstacaoRecargaService
    {
        private readonly IEstacaoRecargaRepository _repository;

        public EstacaoRecargaService(IEstacaoRecargaRepository repository)
        {
            _repository = repository;
        }

        public void Adicionar(EstacaoRecarga estacaoRecarga)
        {
            _repository.Adicionar(estacaoRecarga);
        }

        public void Atualizar(EstacaoRecarga estacaoRecarga)
        {
            _repository.Atualizar(estacaoRecarga);
        }

        public void Excluir(EstacaoRecarga estacaoRecarga)
        {
            _repository.Excluir(estacaoRecarga);
        }

        public IReadOnlyList<EstacaoRecarga> ListarTodos()
        {
            return _repository.Listar();
        }

        public EstacaoRecarga RecuperarPorId(Guid id)
        {
            return _repository.RecuperarPorId(id);
        }
    }
}
