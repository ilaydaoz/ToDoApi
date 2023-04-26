using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoBusiness.Services.Commands.Insert.ToDoLists;
using ToDoDataAccess.Entity;

namespace ToDoBusiness.Services.Commands.Insert.Categories
{
    public class CategoryInsertCommandMapper : Profile
    {
        public CategoryInsertCommandMapper()
        {
            CreateMap<CategoryInsertCommandRequestModel, Category>();
            CreateMap<Category, CategoryInsertCommandResponse>();
        }
    }
}
