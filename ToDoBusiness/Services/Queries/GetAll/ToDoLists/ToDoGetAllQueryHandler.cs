using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoDataAccess.Repository.Abstract;

namespace ToDoBusiness.Services.Queries.GetAll.ToDoLists
{
    public class ToDoGetAllQueryHandler : IRequestHandler<ToDoGetAllQueryRequestModel, List<ToDoGetAllQueryResponse>>
    {
        private readonly IToDoRepository _toDoListRepository;
        private readonly IMapper _mapper;
        public ToDoGetAllQueryHandler(IToDoRepository bookRepository, IMapper mapper)
        {
            _toDoListRepository = bookRepository;
            _mapper = mapper;
        }
        public async Task<List<ToDoGetAllQueryResponse>> Handle(ToDoGetAllQueryRequestModel request, CancellationToken cancellationToken)
        {
            var toDoListEntity = await _toDoListRepository.GetAllAsync();
            var toDo = _mapper.Map<List<ToDoGetAllQueryResponse>>(toDoListEntity);
            return toDo;
        }
    }
}
