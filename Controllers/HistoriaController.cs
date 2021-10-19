using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade_Avaliativa_fase_6_front.Controllers
{
    public class HistoriaController : Controller
    {
        private readonly ILogger<HistoriaController> _logger;

        public HistoriaController(ILogger<HistoriaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}