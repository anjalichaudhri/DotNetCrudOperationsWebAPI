using System;
using System.Collections.Generic;

namespace DotNetCrudOperationsWebAPI.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public string? Number { get; set; }
        public int? PersonId { get; set; }

        public virtual Person? Person { get; set; }
    }
}
