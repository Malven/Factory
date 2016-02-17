using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign.Classes {
    class BestForCustomer : Composite {

        public override IPriceStrategy GetTotal( Order order ) {
            decimal maxValue = decimal.MaxValue;
            IPriceStrategy strategyToReturn = null;

            foreach ( var item in strategies ) {
                if(item.GetTotal( order ) < maxValue ) {
                    maxValue = item.GetTotal( order );
                    strategyToReturn = item;
                }
            }
            return strategyToReturn;
        }
    }
}
