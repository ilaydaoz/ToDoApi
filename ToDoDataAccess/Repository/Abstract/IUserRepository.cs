using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoCore.Repository;
using ToDoEntity.Entity;

namespace ToDoDataAccess.Repository.Abstract
{
    public interface IUserRepository : IBaseRepository<User>
    {
    }
}
