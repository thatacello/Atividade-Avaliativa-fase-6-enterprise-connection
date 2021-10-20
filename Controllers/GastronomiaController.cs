using System.Threading.Tasks;
using Atividade_Avaliativa_fase_6_front.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade_Avaliativa_fase_6_front.Controllers
{
    public class GastronomiaController : Controller
    {
        private readonly GastronomiaService _gastronomiaService;

        public GastronomiaController(GastronomiaService gastronomiaService)
        {
            _gastronomiaService = gastronomiaService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _gastronomiaService.FindAllAsync();
            return View(list);
        }
    }
}