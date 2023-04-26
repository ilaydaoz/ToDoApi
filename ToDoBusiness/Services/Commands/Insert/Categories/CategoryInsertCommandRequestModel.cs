using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoBusiness.Services.Commands.Insert.Categories
{
    public class CategoryInsertCommandRequestModel : IRequest<CategoryInsertCommandResponse>
    {
        public string? Name { get; set; }
    }
}
