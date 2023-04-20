using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoEntity.Entity;

namespace ToDoBusiness.Services.Commands.Insert.ToDoLists
{
    public class ToDoListInsertCommandResponse
    {
        public Guid? UserId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public Guid? CategoryId { get; set; }
    }
}
