using ToDoDataAccess.Context;
using ToDoDataAccess.Entity;
using ToDoDataAccess.Repository.Abstract;

namespace ToDoDataAccess.Repository.Concrete
{
    public class UserRepository : BaseRepository<User, EfContext>, IUserRepository
    {
        public UserRepository(EfContext context) : base(context)
        {
        }
    }
}