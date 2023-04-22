using MediatR;

namespace ToDoBusiness.Services.Commands.Insert.ToDoLists
{
    public class ToDoListInsertCommandRequestModel : IRequest<ToDoListInsertCommandResponse>
    {
        public Guid? UserId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public Guid? CategoryId { get; set; }
    }
}
