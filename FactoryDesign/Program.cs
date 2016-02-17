using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryDesign.Classes;

namespace FactoryDesign {
    class Program {
        static void Main( string[] args ) {
            Factory factory = new Factory();

            factory.order.CreateOrderLine( new Product( "Shovel", 50, 0 ), 3 );
            factory.order.CreateOrderLine( new Product( "Gummistövel", 150, 1 ), 2 );
            factory.order.CreateOrderLine( new Product( "John Deere Traktor", 500, 2 ), 1 );

            IPriceStrategy bestPrice = factory.GetPriceStrategy( CustomerType.Private );

            //Skriver ut totalen av ordern så länge det finns en PriceStrategy i BestForCustomer objektet annars skriver den ut null
            Console.Write(factory.order.ToString());
            Console.WriteLine( ( bestPrice != null ) ? "Total: " + bestPrice.GetTotal( factory.order ).ToString() + "kr inkl. " + bestPrice.ToString() + " rabatt." : "null" );
            Console.ReadKey();
        }
    }

    public enum CustomerType {
        Private, Corporate
    }
}
