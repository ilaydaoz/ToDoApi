using AutoMapper;
using MediatR;
using ToDoDataAccess.Repository.Abstract;
using ToDoEntity.Entity;

namespace ToDoBusiness.Services.Commands.Insert.ToDoLists
{
    public class ToDoListInsertCommandHandler : IRequestHandler<ToDoListInsertCommandRequestModel, ToDoListInsertCommandResponse>
    {
        private readonly IToDoRepository _toDoListRepository;
        private readonly IMapper _mapper;
        public ToDoListInsertCommandHandler(IToDoRepository toDoListRepository, IMapper mapper)
        {
            _toDoListRepository = toDoListRepository;
            _mapper = mapper;
        }

        public async Task<ToDoListInsertCommandResponse> Handle(ToDoListInsertCommandRequestModel request, CancellationToken cancellationToken)
        {
            var toDoListEntity = _mapper.Map<ToDo>(request);
            var toDoList = await _toDoListRepository.InsertAsync(toDoListEntity);
            await _toDoListRepository.SaveAsync();
            // if (await _toDoListRepository.SaveAsync() < 1)
            //
            //{
            //  new Error(ResponseMessages.IdErorBookDelete);
            //}
            var toDoLists =  _mapper.Map<ToDoListInsertCommandResponse>(toDoList);
            return toDoLists;
        }
    }
}
