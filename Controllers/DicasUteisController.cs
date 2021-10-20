using System.Threading.Tasks;
using Atividade_Avaliativa_fase_6_front.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade_Avaliativa_fase_6_front.Controllers
{
    public class DicasUteisController : Controller
    {
        private readonly ILogger<DicasUteisController> _logger;
        private readonly DicasUteisService _dicasUteisService;

        public DicasUteisController(ILogger<DicasUteisController> logger)
        {
            _logger = logger;
        }
        public DicasUteisController(DicasUteisService dicasUteisService)
        {
            _dicasUteisService = dicasUteisService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _dicasUteisService.FindAllAsync();
            return View(list);
        }
    }
}