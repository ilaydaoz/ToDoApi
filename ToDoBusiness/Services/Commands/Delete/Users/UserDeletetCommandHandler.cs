using MediatR;
using ToDoDataAccess.Repository.Abstract;

namespace ToDoListBusiness.Services.Commands.Delete.Users
{
    public class UserDeletetCommandHandler : IRequestHandler<UserDeleteCommandRequestModel, bool>
    {
        private readonly IUserRepository _userRepository;

        public UserDeletetCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<bool> Handle(UserDeleteCommandRequestModel request, CancellationToken cancellationToken)
        {
            var toDoList = await _userRepository.GetByIdAsync(request.Id);

            if (toDoList != null)
            {
                _userRepository.Delete(toDoList);
                if (await _userRepository.SaveAsync() > 0)
                    return true;
            }
            return false;
        }
    }
}
