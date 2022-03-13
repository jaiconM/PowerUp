using PowerUp.Domain.Core.Entidades;

namespace PowerUp.Domain.Core.Interfaces
{
    public interface IEstacaoRecargaService
    {
        IReadOnlyList<EstacaoRecarga> ListarTodos();
        void Adicionar(EstacaoRecarga estacaoRecarga);
        EstacaoRecarga RecuperarPorId(Guid id);
        void Atualizar(EstacaoRecarga estacaoRecarga);
        void Excluir(EstacaoRecarga estacaoRecarga);
    }
}
