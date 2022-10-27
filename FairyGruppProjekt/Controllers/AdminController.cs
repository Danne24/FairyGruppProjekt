using FairyGruppProjekt.Models;
using FairyGruppProjekt.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace FairyGruppProjekt.Controllers
{

    public class AdminController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IOrderRepository _orderRepository;

        public AdminController(IProductRepository productRepository, IOrderRepository orderRepository)
        {
            _productRepository = productRepository;
            _orderRepository = orderRepository;
        }

        public IActionResult Index()
        {
            var products = _productRepository.GetAllProducts.ToList();
            return View(products);
        }



        public IActionResult Create() => View();


        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {

            if (ModelState.IsValid)
            {

                _productRepository.CreateNewProduct(product);
                await _productRepository.SaveAsync();

                TempData["Success"] = "The book was successfully added!";


            }
            else
            {
                ModelState.AddModelError("", "Error creating product");
            }

            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product product = _productRepository.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productRepository.EditProduct(product);
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {

                ModelState.AddModelError("", "Unable to save changes");

            }
            return View(product);
        }

        //[HttpGet]
        //public IActionResult Dashboard()
        //{
        //    IEnumerable<Order> orders;

        //    orders = _orderRepository.GetAllOrdersForDashboard.OrderBy(o => o.OrderId);

        //    return View(orders);
        //}

        [HttpGet]
        public IActionResult Dashboard()
        {
            IEnumerable<Order> orders;

            orders = _orderRepository.GetAllOrdersForDashboard.OrderBy(o => o.OrderId);

            return View(orders);
        }
    }
}
