using Contexts.Contexts;
using Contexts.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using Models.Entities.Abstratct;

namespace Contexts.Repositories.Concrete
{
    public class Repository<T> : IBaseRepository<T> where T : BaseEntity, new()
    {
        private readonly LibraryDB library_DB;

        private readonly DbSet<T> DB_Set;

        public Repository()
        {
            library_DB = new LibraryDB();
            DB_Set = library_DB.Set<T>();
        }


        public void Add(T entity)
        {
            DB_Set.Add(entity);
        }

        public void AddRange(ICollection<T> entities)
        {
            DB_Set.AddRange(entities);
        }

        public void Delete(T entity)
        {
            DB_Set.Remove(entity);
        }

        public ICollection<T> GetAll()
        {
            return DB_Set.ToList();
        }

        public T GetById(int id)
        {
            return DB_Set.FirstOrDefault(t => t.Id == id);
        }

        public void SaveChanges()
        {
            library_DB.SaveChanges();
        }

        public void Update(T entity)
        {
            DB_Set.Update(entity);
        }
    }
}
