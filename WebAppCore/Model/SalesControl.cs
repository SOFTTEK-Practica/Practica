using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore.Model
{
    public class SalesControl
    {
        public int Id { get; set; }
        public DateTime DateSale { get; set; }
        public string seller { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public string Customer { get; set; }
    }
}
