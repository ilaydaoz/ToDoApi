using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoBusiness.Services.Queries.GetAll.ToDoLists
{
    public class ToDoGetAllQueryRequestModel : IRequest<List<ToDoGetAllQueryResponse>>
    {
    }
}
