using System.Threading.Tasks;
using Atividade_Avaliativa_fase_6_front.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade_Avaliativa_fase_6_front.Controllers
{
    public class VidaNoturnaController : Controller
    {
        private readonly ILogger<VidaNoturnaController> _logger;
        private readonly VidaNoturnaService _vidaNoturnaService;

        public VidaNoturnaController(ILogger<VidaNoturnaController> logger)
        {
            _logger = logger;
        }
        public VidaNoturnaController(VidaNoturnaService vidaNoturnaService)
        {
            _vidaNoturnaService = vidaNoturnaService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _vidaNoturnaService.FindAllAsync();
            return View(list);
        }
    }
}