using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoCore.Entites;

namespace ToDoEntity.Entity
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
       
        public ICollection<ToDo> ToDoItems { get; set; }
       
    }
}
