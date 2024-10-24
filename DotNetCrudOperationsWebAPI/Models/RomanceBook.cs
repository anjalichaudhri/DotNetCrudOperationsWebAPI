using System;
using System.Collections.Generic;

namespace DotNetCrudOperationsWebAPI.Models
{
    public partial class RomanceBook
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? AuthorName { get; set; }
        public string? Price { get; set; }
    }
}
