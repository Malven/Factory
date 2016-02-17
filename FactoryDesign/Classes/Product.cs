using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign.Classes {
    public class Product {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int ID { get; set; }

        public Product(string name, decimal price, int id ) {
            Name = name;
            UnitPrice = price;
            ID = id;
        }

    }
}
