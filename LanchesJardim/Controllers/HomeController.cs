using LanchesJardim.Interfaces;
using LanchesJardim.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesJardim.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public HomeController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                LanchesPreferidos = _lancheRepository.LanchesPreferidos
            };

            return View(homeViewModel);
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}

