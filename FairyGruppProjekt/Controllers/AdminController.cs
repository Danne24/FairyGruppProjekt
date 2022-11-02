using FairyGruppProjekt.Models;
using FairyGruppProjekt.Models.Interfaces;
using FairyGruppProjekt.Models.Repositories;

using FairyGruppProjekt.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace FairyGruppProjekt.Controllers
{

    [Authorize(Roles ="Admin")]

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
            
            return View();
        }
        public IActionResult ManageProducts()
        {
            var products = _productRepository.GetAllProducts.ToList();
            return View(products);
        }


        public IActionResult Stock()
        {
            var lowInStock = _productRepository.GetAllProducts.Where(p => p.Amount <= 20);
            return View(lowInStock);
        }
        public IActionResult Index2()
        {
            IEnumerable<Product> products;
            IEnumerable<Order> orders;

            products = _productRepository.GetAllProducts.OrderBy(p => p.ProductId);
            orders = _orderRepository.GetAllOrders();


            return View(new AdminViewModel
            {
                Products = products,
                Orders = orders
            });
        }

        //CREATE PRODUCT VIEW

        public IActionResult Create() => View();

        //CREATE PRODUCT ACTION
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name, Description, Price, IsOnSale, IsInStock, Price, CategoryId")]Product product)
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



        //EDIT PRODUCT VIEW
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product product = _productRepository.GetProductById(id);
            return View(product);
        }

        //EDIT PRODUCT ACTION
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


        [HttpGet]
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

        //DELETE PRODUCT VIEW
        public ActionResult Delete(int id)
        {

            Product customer = _productRepository.GetProductById(id);

            return View(customer);
        }

        //DELETE PRODUCT ACTION
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            _productRepository.DeleteProduct(id);
            _productRepository.Save();
            return RedirectToAction("Index");
        }


        //GET ALL ORDERS
        public IActionResult OrderList()
        {
            var orderList = _orderRepository.GetAllOrders();
            return View(orderList);
        }

        public IActionResult OrderDetails(int id)
        {
            var order = _orderRepository.GetOrderById(id);
            if (order != null)
            {
               
                return View(order);
            }
            return BadRequest("Error retrieving products from this order");
           

        }


        public ActionResult Distance()
        {
            return View();
        }
    }
}
