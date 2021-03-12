using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung {
    abstract class Motorfahzeug : IDriveable {

        public Motor Motor;
        public Human getOwner() {
            throw new NotImplementedException();
        }

        public void setOwner(Human newOwner) {
            throw new NotImplementedException();
        }
    }
}
