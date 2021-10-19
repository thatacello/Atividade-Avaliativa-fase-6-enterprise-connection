using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade_Avaliativa_fase_6_front.Controllers
{
    public class DicasUteisController : Controller
    {
        private readonly ILogger<DicasUteisController> _logger;

        public DicasUteisController(ILogger<DicasUteisController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}