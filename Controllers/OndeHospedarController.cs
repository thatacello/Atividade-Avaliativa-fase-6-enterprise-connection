using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade_Avaliativa_fase_6_front.Controllers
{
    public class OndeHospedarController : Controller
    {
        private readonly ILogger<OndeHospedarController> _logger;

        public OndeHospedarController(ILogger<OndeHospedarController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}