using FairyGruppProjekt.Data;
using FairyGruppProjekt.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FairyGruppProjekt.Models.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Product entity)
        {
            _context.Products.Add(entity);

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.productId == id);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public Product Get(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.productId == id);

            return product;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(Product entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
