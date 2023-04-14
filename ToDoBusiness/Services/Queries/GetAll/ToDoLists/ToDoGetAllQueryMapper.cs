using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoEntity.Entity;

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
