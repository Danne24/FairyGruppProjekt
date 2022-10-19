using FairyGruppProjekt.Models;
using FairyGruppProjekt.Models.Interfaces;
using FairyGruppProjekt.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FairyGruppProjekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _ProductRepository;

        public HomeController(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProductOnSale = _ProductRepository.GetProductOnSale
            };
            return View(homeViewModel);
        }
    }
}