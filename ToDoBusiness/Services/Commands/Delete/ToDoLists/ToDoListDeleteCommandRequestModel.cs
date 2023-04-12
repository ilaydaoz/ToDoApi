using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListBusiness.Services.Commands.Delete.ToDoLists
{
    public class ToDoListDeleteCommandRequestModel : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
