namespace PowerUp.Domain.Core.Entidades
{
    public abstract class EntidadeBase
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
