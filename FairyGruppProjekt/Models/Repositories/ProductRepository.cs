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

        public void CreateNewProduct(Product product)
        {
            _context.Products.Add(product);
        }

        public void DeleteProduct(int id)
        {
            var productToDelete = _context.Products.Find(id);
            _context.Products.Remove(productToDelete);
            _context.SaveChanges();
            
        }

        public void EditProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Product GetProductById(int productId)
        {
            return _context.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public async Task SaveAsync()
        {
           await _context.SaveChangesAsync();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }

  

}
