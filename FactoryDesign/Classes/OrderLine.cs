using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign.Classes {
    public class OrderLine {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal GetSubTotal() {
            return Product.UnitPrice * Quantity;
        }
    }
}
