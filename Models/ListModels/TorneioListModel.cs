using TorneioApp.Models;

namespace TorneioApp.ListModels
{
    public class TorneioListModel
    {
        public string Nome { get; set; } = string.Empty;
        public string Data { get; set; } = string.Empty;
        public Status Status { get; set; } = 0;
    }
}
