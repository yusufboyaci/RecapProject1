using Recap.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.Entities
{
    public class Product: CoreEntity
    {
        public Guid CategoryId { get; set; } //FK
        public string? Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string? QuantityPerUnit { get; set; }
        public int UnitsInStock { get; set; }
        public virtual Category? Category { get; set; }
    }
}
