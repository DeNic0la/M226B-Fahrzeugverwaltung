using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung {
    abstract class Motorfahzeug : IDriveable {

        public Motor Motor;
        public string Kontrollschild;
        public string Marke;
        public string Typ;




        public Human getOwner() {
            throw new NotImplementedException();
        }

        public void setOwner(Human newOwner) {
            throw new NotImplementedException();
        }

        public Motorfahzeug(string seKontrollschild, string seMarke, string seTyp) {
            Kontrollschild = seKontrollschild;
            Marke = seMarke;
            Typ = seTyp;
        }
    }
}
