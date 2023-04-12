using AutoMapper;
using MediatR;
using ToDoDataAccess.Repository.Abstract;
using ToDoEntity.Entity;

namespace ToDoListBusiness.Services.Commands.Insert.Users
{
    public class UserInsertCommandHandler : IRequestHandler<UserInsertCommandRequestModel, UserInsertCommandResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserInsertCommandHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserInsertCommandResponse> Handle(UserInsertCommandRequestModel request, CancellationToken cancellationToken)
        {
            var toDoListEntity = _mapper.Map<User>(request);
            var toDoList = await _userRepository.InsertAsync(toDoListEntity);
            await _userRepository.SaveAsync();
            // if (await _toDoListRepository.SaveAsync() < 1)
            //
            //{
            //  new Error(ResponseMessages.IdErorBookDelete);
            //}
            var toDoLists = _mapper.Map<UserInsertCommandResponse>(toDoList);
            return toDoLists;
        }
    }
}
