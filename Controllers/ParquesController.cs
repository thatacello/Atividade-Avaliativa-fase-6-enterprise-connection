using System.Threading.Tasks;
using Atividade_Avaliativa_fase_6_front.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Atividade_Avaliativa_fase_6_front.Controllers
{
    public class ParquesController : Controller
    {
        private readonly ParquesService _parquesService;

        public ParquesController(ParquesService parquesService)
        {
            _parquesService = parquesService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _parquesService.FindAllAsync();
            return View(list);
        }
    }
}