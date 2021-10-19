using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade_Avaliativa_fase_6_front.Controllers
{
    public class GastronomiaController : Controller
    {
        private readonly ILogger<GastronomiaController> _logger;

        public GastronomiaController(ILogger<GastronomiaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}