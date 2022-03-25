using Microsoft.AspNetCore.Mvc;
using TorneioApp.Data;
using TorneioApp.Models;
using TorneioApp.ListModels;


namespace TorneioApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartidasController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public PartidasController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<PartidaListModel> Index()
        {
            var partidas = _unitOfWork.Partidas.ObterPartidasComJogadores();

            return partidas.Select(p => new PartidaListModel
            {
                NomeTorneio = p.Torneio.Nome,
                Numero = p.NumeroPartida,
                NomeJogadorBrancas = p.JogadorBrancas.Nome,
                NomeJogadorNegras = p.JogadorNegras.Nome,
                ResultadoPartida = p.ResultadoPartida
            });
        }

        //[HttpGet("Adicionar")]
        //public IActionResult Adicionar()
        //{
        //    var Partida = new Partida
        //    {
        //        JogadorNegras = _unitOfWork.Jogadores.ObterPorId(new Guid("9C7812FD-F8A5-4BB6-B965-10AC8CED166D")),
        //        JogadorBrancas = _unitOfWork.Jogadores.ObterPorId(new Guid("4FE72451-64E8-4E51-B2AE-44B6A4039984")),
        //        Torneio = _unitOfWork.Torneios.ObterTodos().FirstOrDefault()
        //    };

        //    _unitOfWork.Partidas.Adicionar(Partida);
        //    _unitOfWork.Complete();

        //    return Ok();
        //}
    }
}
