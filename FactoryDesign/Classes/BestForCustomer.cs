using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign.Classes {
    class BestForCustomer : Composite {

        public override decimal GetTotal( Order order ) {
            decimal p = new PercentDiscount().GetTotal(order);
            decimal t = new ThresholdDiscount().GetTotal( order );

            foreach ( var item in strategies ) {
                if ( p > t )
                    return t;
                else
                    return p;
            }
            return p;
        }
    }
}
