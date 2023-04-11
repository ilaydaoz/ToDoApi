using ToDoCore.Entites;

namespace ToDoEntity.Entity
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<ToDo> ToDoItems { get; set; }
    }
}
