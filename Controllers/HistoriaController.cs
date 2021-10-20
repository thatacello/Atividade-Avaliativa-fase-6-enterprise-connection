using System.Threading.Tasks;
using Atividade_Avaliativa_fase_6_front.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade_Avaliativa_fase_6_front.Controllers
{
    public class HistoriaController : Controller
    {
        private readonly HistoriaService _historiaService;

        public HistoriaController(HistoriaService historiaService)
        {
            _historiaService = historiaService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _historiaService.FindAllAsync();
            return View(list);
        }
    }
}