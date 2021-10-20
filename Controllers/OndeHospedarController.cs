using System.Threading.Tasks;
using Atividade_Avaliativa_fase_6_front.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade_Avaliativa_fase_6_front.Controllers
{
    public class OndeHospedarController : Controller
    {
        private readonly ILogger<OndeHospedarController> _logger;
        private readonly OndeHospedarService _ondeHospedarService;

        public OndeHospedarController(ILogger<OndeHospedarController> logger)
        {
            _logger = logger;
        }
        public OndeHospedarController(OndeHospedarService ondeHospedarService)
        {
            _ondeHospedarService = ondeHospedarService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _ondeHospedarService.FindAllAsync();
            return View(list);
        }
    }
}