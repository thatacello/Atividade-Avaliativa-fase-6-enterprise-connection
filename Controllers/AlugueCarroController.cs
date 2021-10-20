using System.Threading.Tasks;
using Atividade_Avaliativa_fase_6_front.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade_Avaliativa_fase_6_front.Controllers
{
    public class AlugueCarroController : Controller
    {
        private readonly ILogger<AlugueCarroController> _logger;
        private readonly AlugueCarroService _alugueCarroService;

        public AlugueCarroController(ILogger<AlugueCarroController> logger)
        {
            _logger = logger;
        }
        public AlugueCarroController(AlugueCarroService alugueCarroService)
        {
            _alugueCarroService = alugueCarroService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _alugueCarroService.FindAllAsync();
            return View(list);
        }
    }
}