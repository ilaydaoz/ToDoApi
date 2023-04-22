using AutoMapper;
using ToDoDataAccess.Entity;

namespace ToDoBusiness.Services.Queries.GetByFilter.Categories
{
    public class CategoryGetByFilterQueryMapper : Profile
    {
        public CategoryGetByFilterQueryMapper()
        {
            CreateMap<Category, CategoryGetByFilterQueryResponse>();
        }
    }
}
