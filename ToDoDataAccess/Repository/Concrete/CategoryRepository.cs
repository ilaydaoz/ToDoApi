using ToDoDataAccess.Context;
using ToDoDataAccess.Entity;
using ToDoDataAccess.Repository.Abstract;

namespace ToDoDataAccess.Repository.Concrete
{
    public class CategoryRepository : BaseRepository<Category, EfContext>, ICategoryRepository
    {
        public CategoryRepository(EfContext context) : base(context)
        {
        }
    }
}
