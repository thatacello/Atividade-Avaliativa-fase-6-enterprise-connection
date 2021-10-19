using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade_Avaliativa_fase_6_front.Controllers
{
    public class ComoChegarController : Controller
    {
        private readonly ILogger<ComoChegarController> _logger;

        public ComoChegarController(ILogger<ComoChegarController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}