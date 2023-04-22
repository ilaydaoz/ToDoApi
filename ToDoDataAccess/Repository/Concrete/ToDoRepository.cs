using ToDoDataAccess.Context;
using ToDoDataAccess.Entity;
using ToDoDataAccess.Repository.Abstract;

namespace ToDoDataAccess.Repository.Concrete
{
    public class ToDoRepository : BaseRepository<ToDo, EfContext>, IToDoRepository
    {
        public ToDoRepository(EfContext context) : base(context)
        {
        }
    }
}
