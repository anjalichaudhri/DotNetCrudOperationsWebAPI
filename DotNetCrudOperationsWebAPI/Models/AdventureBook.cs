using System;
using System.Collections.Generic;

namespace DotNetCrudOperationsWebAPI.Models
{
    public partial class AdventureBook
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? AuthorName { get; set; }
    }
}
