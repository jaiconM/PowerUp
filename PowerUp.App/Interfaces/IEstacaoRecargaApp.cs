using PowerUp.Domain.Core.Entidades;

namespace PowerUp.App.Interfaces
{
    public interface IEstacaoRecargaApp
    {
        IReadOnlyList<EstacaoRecarga> ListarTodos();
        void Adicionar(EstacaoRecarga estacaoRecarga);
        EstacaoRecarga RecuperarPorId(Guid id);
        void Atualizar(EstacaoRecarga estacaoRecarga);
        void Excluir(EstacaoRecarga estacaoRecarga);
    }
}