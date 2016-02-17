using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign.Classes {
    public class Factory {
        public Order order = new Order();        

        PercentDiscount p = new PercentDiscount();
        ThresholdDiscount t = new ThresholdDiscount();

        public IPriceStrategy GetPriceStrategy(string name) {

            if ( name == PercentDiscount.Name )
                return new PercentDiscount();
            else if ( name == ThresholdDiscount.Name )
                return new ThresholdDiscount();

            return null;
        }

        public decimal GetPriceStrategy(CustomerType cType ) {
            if ( cType == CustomerType.Private ) {
                BestForCustomer bc = new BestForCustomer();
                bc.Add( p );
                bc.Add( t );
                return bc.GetTotal( order );
            }

            return 0;
        }

    }
}
