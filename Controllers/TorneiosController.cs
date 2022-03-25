using Microsoft.AspNetCore.Mvc;
using TorneioApp.Data;
using TorneioApp.Models;
using TorneioApp.ListModels;

namespace TorneioApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TorneiosController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public TorneiosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<TorneioListModel> Index()
        {
            var torneios = _unitOfWork.Torneios.ObterTodos();

            return torneios.Select(t => new TorneioListModel
            {
                Nome = t.Nome,
                Data = t.Data.ToString("d/MM/yy"),
                Status = t.Status
            });
        }

        //[HttpGet("Adicionar")]
        //public IActionResult Adicionar()
        //{
        //    var torneio = new Torneio
        //    {
        //        Nome = "Torneio 03"
        //    };

        //    _unitOfWork.Torneios.Adicionar(torneio);
        //    _unitOfWork.Complete();

        //    return Ok();
        //}
    }
}
