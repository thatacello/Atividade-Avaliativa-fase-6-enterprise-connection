using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade_Avaliativa_fase_6_front.Controllers
{
    public class AlugueCarroController : Controller
    {
        private readonly ILogger<AlugueCarroController> _logger;

        public AlugueCarroController(ILogger<AlugueCarroController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}