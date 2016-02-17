using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign.Classes {
    public abstract class Composite {
        public List<IPriceStrategy> strategies = new List<IPriceStrategy>();

        public void Add( IPriceStrategy ips ) {
            strategies.Add( ips );
        }

        public abstract IPriceStrategy GetTotal( Order order );
    }
}
