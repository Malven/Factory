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
            decimal bestPrice = factory.GetPriceStrategy( CustomerType.Private );
            Console.WriteLine( bestPrice );
            Console.ReadKey();
        }
    }

    public enum CustomerType {
        Private, Corporate
    }
}
