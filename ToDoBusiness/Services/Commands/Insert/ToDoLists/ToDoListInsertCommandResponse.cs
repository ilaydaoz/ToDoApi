namespace ToDoBusiness.Services.Commands.Insert.ToDoLists
{
    public class ToDoListInsertCommandResponse
    {
        public Guid? UserId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Priority { get; set; }
        public Guid? CategoryId { get; set; }
    }
}
