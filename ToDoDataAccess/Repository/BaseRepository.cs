using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ToDoCore.Entites;
using ToDoCore.Repository;
using ToDoDataAccess.Context;

namespace ToDoDataAccess.Repository
{
    public class BaseRepository<T, IContext> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly EfContext _context;
        protected readonly DbSet<T> DbSet;
        public BaseRepository(EfContext context)
        {
            _context = context;
            DbSet = _context.Set<T>();
        }
        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync()
        {
            return _context.Set<T>().ToListAsync();
        }

        public Task<T> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<T> InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Guid> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetByFilter(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).ToList();
        }
    }
}
