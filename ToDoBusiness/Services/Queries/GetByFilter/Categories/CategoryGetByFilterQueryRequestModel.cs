using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoBusiness.Services.Queries.GetByFilter.Categories
{
    public class CategoryGetByFilterQueryRequestModel : IRequest<List<CategoryGetByFilterQueryResponse>>
    {
    }
}
