using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign.Classes {
    class ThresholdDiscount : IPriceStrategy {

        public static string Name = "ThresholdDiscount";
        private decimal discount = 0.07M;
        private int threshold = 400;

        public decimal GetTotal( Order order ) {
            if ( order.GetTotal() > threshold ) {
                decimal temp = order.GetTotal() * discount;
                return order.GetTotal() - temp;
            }
            else
                return order.GetTotal();
        }
    }
}
