namespace Contexts.Repositories.Abstract
{
    public interface IBaseRepository<T>
    {
        T GetById(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        ICollection<T> GetAll();

        void AddRange(ICollection<T> entities);

        void SaveChanges();
    }
}
