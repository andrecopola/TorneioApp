using Microsoft.AspNetCore.Mvc;
using TorneioApp.Data;
using TorneioApp.Models;

namespace TorneioApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogadoresController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;

        public JogadoresController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<Jogador> Get()
        {
            var jogadores = _unitOfWork.Jogadores.ObterTodos().OrderBy(j => j.Nome);
            return jogadores;
        }

        [HttpGet("Adicionar")]
        public IActionResult Adicionar()
        {
            var torneios = _unitOfWork.Torneios.ObterTodos().ToList();

            var jogador = new Jogador
            {
                Nome = "Magnus Carlsen",
                Torneios = torneios
            };

            _unitOfWork.Jogadores.Adicionar(jogador);
            _unitOfWork.Complete();

            return Ok();
        }
    }
}
