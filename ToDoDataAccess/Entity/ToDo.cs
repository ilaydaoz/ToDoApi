using System.ComponentModel.DataAnnotations.Schema;
using ToDoCore.Entites;

namespace ToDoDataAccess.Entity
{
    [Table("ToDo", Schema = "Entity")]
    public class ToDo : BaseEntity
    {

        public string Title { get; set; }
        public string? Description { get; set; }

       // public User User { get; set; }
       // public Guid? UserId { get; set; }

       // public Guid? CategoryId { get; set; }
       // public Category Category { get; set; }
    }
}
