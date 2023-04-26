using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoDataAccess.Entity;
using ToDoDataAccess.Repository.Abstract;

namespace ToDoBusiness.Services.Commands.Insert.Categories
{
        public class CategoryInsertCommandHandler : IRequestHandler<CategoryInsertCommandRequestModel, CategoryInsertCommandResponse>
        {
            private readonly ICategoryRepository _categoryRepository;
            private readonly IMapper _mapper;
            public CategoryInsertCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
            {
            _categoryRepository = categoryRepository;
                _mapper = mapper;
            }

            public async Task<CategoryInsertCommandResponse> Handle(CategoryInsertCommandRequestModel request, CancellationToken cancellationToken)
            {
                var toDoListEntity = _mapper.Map<Category>(request);
                var toDoList = await _categoryRepository.InsertAsync(toDoListEntity);
                await _categoryRepository.SaveAsync();
                // if (await _toDoListRepository.SaveAsync() < 1)
                //
                //{
                //  new Error(ResponseMessages.IdErorBookDelete);
                //}
                var toDoLists = _mapper.Map<CategoryInsertCommandResponse>(toDoList);
                return toDoLists;
            }

        }
}

