using FairyGruppProjekt.Data;
using FairyGruppProjekt.Models;
using FairyGruppProjekt.Models.Interfaces;
using FairyGruppProjekt.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FairyGruppProjekt.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ApplicationDbContext _appDbContext;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository, ApplicationDbContext appdbcontext)
        {
            _productRepository = productRepository;
           _categoryRepository = categoryRepository;
            _appDbContext = appdbcontext;
        }

        public ViewResult List(string category)
        {
            
            IEnumerable<Product> products;
            string currentCategory;
            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.GetAllProducts.OrderBy(p => p.ProductId);
                currentCategory = "Products";
            }
            else
            {
                products = _productRepository.GetAllProducts.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategory.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ProductListViewModel
            {
              
                Products = products,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var ExVal = _appDbContext.usedCurrencies.FirstOrDefault(a => a.TempKey == 1);
            var product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            product.Price *= ExVal.CurValue;
            return View(product);
        }
        public IActionResult SetPrice()
        {
            var ExVal = _appDbContext.usedCurrencies.FirstOrDefault(a => a.TempKey == 1);
  
            return View();
        }
    }
}
