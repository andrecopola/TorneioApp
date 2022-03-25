using TorneioApp.Models;

namespace TorneioApp.ListModels
{
    public class PartidaListModel
    {
        public short Numero { get; set; }
        public string NomeJogadorBrancas { get; set; } = string.Empty;
        public string NomeJogadorNegras { get; set; } = string.Empty;
        public string NomeTorneio { get; set; } = string.Empty;
        public ResultadoPartida ResultadoPartida { get; set; }
    }
}
