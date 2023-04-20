using System.ComponentModel.DataAnnotations.Schema;
using ToDoCore.Entites;

namespace ToDoEntity.Entity
{
    [Table("Category", Schema = "Entity")]
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
       //public ICollection<ToDo>? ToDoItems { get; set; }
    }
}
