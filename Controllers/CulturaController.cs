using System.Threading.Tasks;
using Atividade_Avaliativa_fase_6_front.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade_Avaliativa_fase_6_front.Controllers
{
    public class CulturaController : Controller
    {
        private readonly ILogger<CulturaController> _logger;
        private readonly CulturaService _alugueCarroService;

        public CulturaController(ILogger<CulturaController> logger)
        {
            _logger = logger;
        }
        public CulturaController(CulturaService culturaService)
        {
            _alugueCarroService = culturaService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _alugueCarroService.FindAllAsync();
            return View(list);
        }
    }
}