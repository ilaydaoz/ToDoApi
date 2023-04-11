using ToDoCore.Entites;

namespace ToDoEntity.Entity
{
    public class ToDo : BaseEntity
    {
        public string Title { get; set; }
        public string? Description { get; set; }

        public User User { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
