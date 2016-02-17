using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign.Classes {
    public class Factory {
        public Order order = new Order();        

        PercentDiscount percentDiscount = new PercentDiscount();
        ThresholdDiscount thresholdDiscount = new ThresholdDiscount();
        
        //Gamla sättet med strängar
        //public IPriceStrategy GetPriceStrategy(string name) {

        //    if ( name == PercentDiscount.Name )
        //        return new PercentDiscount();
        //    else if ( name == ThresholdDiscount.Name )
        //        return new ThresholdDiscount();

        //    return null;
        //}
        public IPriceStrategy GetPriceStrategy(CustomerType cType ) {
            if ( cType == CustomerType.Private ) {
                BestForCustomer bc = new BestForCustomer();
                bc.Add( percentDiscount );
                bc.Add( thresholdDiscount );
                return bc.GetTotal( order );
            }
            return null;
        }
    }
}
