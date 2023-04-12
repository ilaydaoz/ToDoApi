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
            DbSet.Remove(entity);
            return true;
        }

        public Task<List<T>> GetAllAsync()
        {
            return _context.Set<T>().ToListAsync();
        }

        public Task<T> GetByIdAsync(Guid Id)
        {
            return _context.Set<T>().FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<T> InsertAsync(T entity)
        {
            DbSet.Add(entity);
            return entity;
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<Guid> UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return entity.Id;
        }

        public ICollection<T> GetByFilter(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).ToList();
        }
    }
}
