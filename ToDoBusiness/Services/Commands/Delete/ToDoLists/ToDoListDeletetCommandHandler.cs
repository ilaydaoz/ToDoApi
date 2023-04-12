using MediatR;
using ToDoDataAccess.Repository.Abstract;

namespace ToDoListBusiness.Services.Commands.Delete.ToDoLists
{
    public class ToDoListDeletetCommandHandler : IRequestHandler<ToDoListDeleteCommandRequestModel, bool>
    {
        private readonly IToDoRepository _toDoListRepository;

        public ToDoListDeletetCommandHandler(IToDoRepository toDoListRepository)
        {
            _toDoListRepository = toDoListRepository;
        }
        public async Task<bool> Handle(ToDoListDeleteCommandRequestModel request, CancellationToken cancellationToken)
        {
            var toDoList = await _toDoListRepository.GetByIdAsync(request.Id);

            if (toDoList != null)
            {
                _toDoListRepository.Delete(toDoList);
                if (await _toDoListRepository.SaveAsync() > 0)
                    return true;
            }
            return false;
        }
    }
}
