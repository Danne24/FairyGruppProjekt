using FairyGruppProjekt.Models;
using FairyGruppProjekt.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FairyGruppProjekt.Controllers
{
    
    public class AdminController : Controller
    {
        private readonly IProductRepository _productRepository;
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Create() => View();


        [HttpPost]
        [ActionName("CreateProduct")]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.CreateNewProduct(product);
                await _productRepository.SaveAsync();
            }
            else
            {
                ModelState.AddModelError("", "Error creating product");
            }

            TempData["Success"] = "The book was successfully added!";
            return RedirectToAction("Index");
        }
    }
}
