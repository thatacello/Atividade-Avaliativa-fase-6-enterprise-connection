using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade_Avaliativa_fase_6_front.Controllers
{
    public class EntretenimentoController : Controller
    {
        private readonly ILogger<EntretenimentoController> _logger;

        public EntretenimentoController(ILogger<EntretenimentoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}