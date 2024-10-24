using System;
using System.Collections.Generic;

namespace DotNetCrudOperationsWebAPI.Models
{
    public partial class Person
    {
        public Person()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
        public string? AadharId { get; set; }
        public string? Location { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
