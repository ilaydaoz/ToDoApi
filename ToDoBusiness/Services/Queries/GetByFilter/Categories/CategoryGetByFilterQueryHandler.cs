using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoDataAccess.Repository.Abstract;

namespace ToDoBusiness.Services.Queries.GetByFilter.Categories
{
    public class CategoryGetByFilterQueryHandler : IRequestHandler<CategoryGetByFilterQueryRequestModel, List<CategoryGetByFilterQueryResponse>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryGetByFilterQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<List<CategoryGetByFilterQueryResponse>> Handle(CategoryGetByFilterQueryRequestModel request, CancellationToken cancellationToken)
        {// HasValue : null olup olmadığını kontrol ediyo.
            var categories = await _categoryRepository.GetByFilterAsync(c =>
            (string.IsNullOrEmpty(request.Name) || c.Name.Contains(request.Name)));
               // (string.IsNullOrEmpty(request.Description) || c.Description.Contains(request.Description)) &&
              //  (!request.UrgencyLevel.HasValue || c.UrgencyLevel == request.UrgencyLevel));
            var categoryResponses =  _mapper.Map<List<CategoryGetByFilterQueryResponse>>(categories);
            return categoryResponses;
        }
    }
}
