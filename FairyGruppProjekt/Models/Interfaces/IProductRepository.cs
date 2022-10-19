namespace FairyGruppProjekt.Models.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts { get; }
        IEnumerable<Product> GetProductOnSale { get; }

        Product GetProductById(int productId);
    }
}
