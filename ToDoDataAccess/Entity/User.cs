using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoCore.Entites;

namespace ToDoDataAccess.Entity
{
    [Table("User", Schema = "Entity")]
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

       // [ForeignKey("ToDoItemsId")]
      //  public ICollection<ToDo> ToDoItems { get; set; }
       
    }
}
