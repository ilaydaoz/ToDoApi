using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListBusiness.Services.Commands.Delete.Users
{
    public class UserDeleteCommandRequestModel : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
