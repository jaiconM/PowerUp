using PowerUp.Domain.Core.Enums;

namespace PowerUp.Domain.Core.Entidades
{
    public class EstacaoRecarga
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Tipo Tipo { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}