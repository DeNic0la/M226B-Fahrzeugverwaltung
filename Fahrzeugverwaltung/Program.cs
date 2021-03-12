using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeugverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            // (1) Fahrzeugobjekte anlegen
            Auto a1 = new Auto("LU 25958", "Toyota", "Corolla");
            Auto a2 = new Auto("LU 122298");
            a2.Marke = "Volvo";
            a2.Typ = "V40";
            a2.Motor.Hubraum = 1800; //ccm
            a2.Motor.Leistung = 135; //PS
            a2.Motor.AnzahlZylinder = 4; //Zylinder
            a2.Motor.Bauart = Motorbauuarten.ReihenMotor;
            Auto a3 = new Auto("LU 64624", "VW", "Käfer", 1500/*ccm*/, 70/*PS*/, 4 /*Zylinder*/, Motorbauuarten.BoxerMotor);
            //
            Motorrad m1 = new Motorrad("LU 14062", "Kawasaki", "Zephir");
            Motorrad m2 = new Motorrad("LU 14064");
            m2.Marke = "Piaggio";
            m2.Typ = "Vespa";
            m2.Motor.Hubraum = 125; //ccm
            m2.Motor.Leistung = 8; //PS
            m2.Motor.AnzahlZylinder = 1; //Zylinder
            Motorrad m3 = new Motorrad("LU 74256", "Yamaha", "XV Wildstar", 1600/*ccm*/, 63/*PS*/, 2/*Zylinder*/, Motorbauuarten.VMotor);
            //
            Fahrrad f1 = new Fahrrad("K124AS123", "Wheeler", "Cross1");
            Fahrrad f2 = new Fahrrad("D424AS144");
            f2.Marke = "Wheeler";
            f2.Typ = "Cross3";
            Fahrrad f3 = new Fahrrad("K123AD351", "Wheeler", "Cross3");
            // (2) Fahrzeugobjekte im Fahrzeugverzeichnis(Arrayliste) speichern
            Fahrzeugverzeichnis f = new Fahrzeugverzeichnis();
            f.Add(a1);
            f.Add(a2);
            f.Add(a3);
            f.Add(m1);
            f.Add(m2);
            f.Add(m3);
            f.Add(f1);
            f.Add(f2);
            f.Add(f3);
            // (3) Personenobjekte erstellen
            Person p1 = new Person();
            p1.setPersNr(120);
            p1.setName("Gugerli");
            p1.setVorname("Armin");
            p1.setStrasse("Schürstrasse");
            p1.getWohnort().setPlz("6020");
            p1.getWohnort().setOrt("Emmenbruecke");
            Person p2 = new Person(123, "Bucher", "Roland", "Sonnbüel13");
            p2.getWohnort().setPlz("6024");
            p2.getWohnort().setOrt("Hildisrieden");
            Person p3 = new Person(130, "Waldburger", "Max", "Hauptweg 101", new Ortschaft("8805", "Freienbach"));
            // (4) Fahrzeuge den Personenobjekten zuweisen oder/und umgekehrt
            a1.setBesitzer(p2);
            m1.setBesitzer(p2);
            a2.setBesitzer(p2);
            p1.AddFahrzeug(a2);
            p1.AddFahrzeug(f2);
            // (5) Ausgabe aller Fahrzeuge
            Console.WriteLine("*********************************");
            Console.WriteLine("A L L E   F A H R Z E U G E     ");
            Console.WriteLine("*********************************");
            foreach (Fahrzeug f in Fahrzeugverzeichnis.Fahrzeuge)
            {
                f.Datenausgabe();
                Console.WriteLine("----------------------------------");
            }
            Console.WriteLine("*********************************");
            Console.WriteLine("A L L E   P E R S O N  E N     ");
            Console.WriteLine("*********************************");
            p1.Datenausgabe();
            p2.Datenausgabe();
            p3.Datenausgabe();
            Console.ReadLine();

        }
    }
}
