using ToDoDataAccess.Context;
using ToDoDataAccess.Repository.Abstract;
using ToDoEntity.Entity;

namespace ToDoDataAccess.Repository.Concrete
{
    public class ToDoRepository : BaseRepository<ToDo, EfContext>, IToDoRepository
    {
        public ToDoRepository(EfContext context) : base(context)
        {
        }
    }
}
