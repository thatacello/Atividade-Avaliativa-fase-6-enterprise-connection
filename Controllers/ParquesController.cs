using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade_Avaliativa_fase_6_front.Controllers
{
    public class ParquesController : Controller
    {
        private readonly ILogger<ParquesController> _logger;

        public ParquesController(ILogger<ParquesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}