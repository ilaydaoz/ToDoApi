namespace ToDoBusiness.Services.Queries.GetAll.ToDoLists
{
    public class ToDoGetAllQueryResponse
    {
        public Guid? UserId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Priority { get; set; }
        public Guid CategoryId { get; set; }
    }
}
