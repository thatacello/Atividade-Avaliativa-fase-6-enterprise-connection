using System.Threading.Tasks;
using Atividade_Avaliativa_fase_6_front.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade_Avaliativa_fase_6_front.Controllers
{
    public class EntretenimentoController : Controller
    {
        private readonly ILogger<EntretenimentoController> _logger;
        private readonly EntretenimentoService _entretenimentoService;

        public EntretenimentoController(ILogger<EntretenimentoController> logger)
        {
            _logger = logger;
        }
        public EntretenimentoController(EntretenimentoService entretenimentoService)
        {
            _entretenimentoService = entretenimentoService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _entretenimentoService.FindAllAsync();
            return View(list);
        }
    }
}