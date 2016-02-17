using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign.Classes {
    public class Order {
        public List<OrderLine> OrderLines = new List<OrderLine>();

        public void CreateOrderLine(Product product, int quantity ) {
            OrderLine ol = new OrderLine();
            ol.Product = product;
            ol.Quantity = quantity;
            OrderLines.Add( ol );
        }

        public decimal GetTotal() {
            decimal sum = 0;
            foreach ( var item in OrderLines ) {
                sum += item.GetSubTotal();
            }
            return sum;
        }

        public override string ToString() {
            string temp = "";
            foreach ( var item in OrderLines ) {
                temp += item.Product.Name + ": " + item.Quantity + "st á " + item.Product.UnitPrice + "kr.\n";
            }
            return temp;
        }
    }
}
