namespace FairyGruppProjekt.Models.Interfaces
{
    public interface IRepository<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Delete(int id);
        void Update(T entity);
        void Add(T entity);
        void Save();
        Task SaveAsync();
    }
}
