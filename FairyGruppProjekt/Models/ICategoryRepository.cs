namespace FairyGruppProjekt.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategory { get; }
    }
}
