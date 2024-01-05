using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vella.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string ?Code { get; set; }
        public string Name { get; set; }
        public string ?Description { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ?UnitAmount { get; set; }
        public int Available { get; set; } = 0;
        public string ?Photo { get; set; }
        public string ?Category { get; set; }
    }
}
