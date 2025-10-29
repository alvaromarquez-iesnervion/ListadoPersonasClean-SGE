using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UI.Models;
using CleanPeopleList.Domain.Interfaces;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index([FromServices] IGetListadoPersonasUseCase getListadoPersonasUseCase)
        {
            var personas = getListadoPersonasUseCase.Execute();
            return View(personas);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}