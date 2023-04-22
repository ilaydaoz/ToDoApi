using AutoMapper;
using ToDoDataAccess.Entity;

namespace ToDoListBusiness.Services.Commands.Insert.Users
{
    public class UsertInsertCommandMapper : Profile
    {
        public UsertInsertCommandMapper()
        {
            CreateMap<UserInsertCommandRequestModel, User>();
            CreateMap<User, UserInsertCommandResponse>();
        }
    }
}
