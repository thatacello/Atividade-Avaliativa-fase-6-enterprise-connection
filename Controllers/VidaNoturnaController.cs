using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade_Avaliativa_fase_6_front.Controllers
{
    public class VidaNoturnaController : Controller
    {
        private readonly ILogger<VidaNoturnaController> _logger;

        public VidaNoturnaController(ILogger<VidaNoturnaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}