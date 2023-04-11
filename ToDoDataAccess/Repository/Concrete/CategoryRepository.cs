using ToDoDataAccess.Context;
using ToDoDataAccess.Repository.Abstract;
using ToDoEntity.Entity;

namespace ToDoDataAccess.Repository.Concrete
{
    public class CategoryRepository : BaseRepository<Category, EfContext>, ICategoryRepository
    {
        public CategoryRepository(EfContext context) : base(context)
        {
        }
    }
}
