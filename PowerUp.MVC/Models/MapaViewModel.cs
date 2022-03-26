using PowerUp.Domain.Core.Entidades;
using PowerUp.Domain.Core.Enums;

namespace PowerUp.MVC.Models
{
    public class MapaViewModel
    {
        private const string IconeTipoMovel = "http://maps.google.com/mapfiles/ms/icons/blue-dot.png";
        private const string IconeTipoVeicular = "http://maps.google.com/mapfiles/ms/icons/green-dot.png";

        public string LatitudeCentral { get; set; }
        public string LongitudeCentral { get; set; }
        public List<EstacoesDeRecargaViewModel> EstacoesRecarga { get; set; }

        public MapaViewModel(IReadOnlyList<EstacaoRecarga> estacoesDeRecarga)
        {
            EstacoesRecarga = new List<EstacoesDeRecargaViewModel>();
            LatitudeCentral = "-22.905895419011326"; // centro do Rio, perto da Infnet.
            LongitudeCentral = "-43.17685031645948"; // em um cenário real, esses dados poderiam ser lidos do browser ou smartphone

            foreach (var estacao in estacoesDeRecarga)
            {
                EstacoesRecarga.Add(
                    new EstacoesDeRecargaViewModel
                    {
                        Icone = estacao.Tipo == Tipo.Veicular ? IconeTipoVeicular : IconeTipoMovel,
                        Titulo = $"{estacao.Nome} (Tipo: {estacao.Tipo})",
                        Latitude = estacao.Latitude.ToString().Replace(',', '.'),
                        Longitude = estacao.Longitude.ToString().Replace(',', '.')
                    }
                );
            }
        }
    }
}