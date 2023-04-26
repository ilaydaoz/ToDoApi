using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoBusiness.Services.Queries.GetByFilter.Categories
{
    public class CategoryGetByFilterQueryResponse
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? UrgencyLevel { get; set; }
    }
}
