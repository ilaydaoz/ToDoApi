using System.ComponentModel.DataAnnotations.Schema;
using ToDoCore.Entites;

namespace ToDoDataAccess.Entity
{
    [Table("Category", Schema = "Entity")]
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? UrgencyLevel { get; set; }
        public ICollection<ToDo>? ToDoItems { get; set; }
    }
}
