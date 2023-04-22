using AutoMapper;
using ToDoDataAccess.Entity;

namespace ToDoBusiness.Services.Queries.GetAll.ToDoLists
{
    public class ToDoGetAllQueryMapper : Profile
    {
        public ToDoGetAllQueryMapper() 
        {
            CreateMap<ToDo, ToDoGetAllQueryResponse>();
        }
    }
}
