using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung {
    interface IDriveable {
        void setOwner(Human newOwner);
        Human getOwner();
    }
}
