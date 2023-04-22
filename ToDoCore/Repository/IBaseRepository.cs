using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToDoCore.Entites;

namespace ToDoCore.Repository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid Id);
        Task<Guid> UpdateAsync(T entity);
        Task<T> InsertAsync(T entity);
        bool Delete(T entity);
        Task<int> SaveAsync();
        Task<ICollection<T>> GetByFilterAsync(Expression<Func<T, bool>> filter);
    }
}
