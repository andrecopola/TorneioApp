using Microsoft.AspNetCore.Mvc;
using TorneioApp.Data;
using TorneioApp.Models;

namespace TorneioApp.Controllers
{
    public class TorneiosController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public TorneiosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            var torneios = _unitOfWork.Torneios.ObterTodos().ToList();

            return Ok(torneios);
        }

        public IActionResult Adicionar()
        {
            var torneio = new Torneio
            {
                Nome = "Torneio 03"
            };

            _unitOfWork.Torneios.Adicionar(torneio);
            _unitOfWork.Complete();

            return Ok();
        }
    }
}
