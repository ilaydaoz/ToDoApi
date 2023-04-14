using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoBusiness.Services.Queries.GetAll.ToDoLists
{
    public class ToDoGetAllQueryResponse
    {
        public Guid? UserId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public Guid CategoryId { get; set; }
    }
}
