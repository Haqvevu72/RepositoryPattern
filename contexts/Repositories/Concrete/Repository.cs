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
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
