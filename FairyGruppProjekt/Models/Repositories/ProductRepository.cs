using FairyGruppProjekt.Data;
using FairyGruppProjekt.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FairyGruppProjekt.Models.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts
        {
            get
            {
                return _context.Products.Include(p => p.Category);
            }
        }

        public IEnumerable<Product> GetProductOnSale
        {

            get
            {
                return _context.Products.Include(p => p.Category).Where(p => p.IsOnSale);
            }

        }

        public Product GetProductById(int productId)
        {
            return _context.Products.FirstOrDefault(p => p.ProductId == productId);
        }
    }

  

}
