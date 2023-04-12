using AutoMapper;
using ToDoEntity.Entity;

namespace ToDoBusiness.Services.Commands.Insert.ToDoLists
{
    public class ToDoListInsertCommandMapper : Profile
    {
        public ToDoListInsertCommandMapper ()
        {
            CreateMap<ToDoListInsertCommandRequestModel, ToDo>();
            CreateMap<ToDo, ToDoListInsertCommandResponse>();
        }
    }
}
