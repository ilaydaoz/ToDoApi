using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoDataAccess.Context;
using ToDoDataAccess.Repository.Abstract;
using ToDoEntity.Entity;

namespace ToDoDataAccess.Repository.Concrete
{
    public class UserRepository : BaseRepository<User, EfContext>, IUserRepository
    {
        public UserRepository(EfContext context) : base(context)
        {
        }
    }
}