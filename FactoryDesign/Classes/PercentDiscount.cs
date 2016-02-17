using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign.Classes {
    class PercentDiscount : IPriceStrategy {

        public static string Name = "PercentDiscount";
        private decimal discount = 0.04M;

        public decimal GetTotal( Order order ) {
            decimal temp = order.GetTotal() * discount;
            return order.GetTotal() - temp;
        }
    }
}
