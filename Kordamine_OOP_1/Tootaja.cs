using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    class Tootaja : Isik
    {
        public string amet;
        public int palk;
        public double maksuvaba;
        public double tulumaks;

        public Tootaja(string nimi, sugu inimSugu, int synniAasta, int kaal, string amet, int palk, int maksuvaba, int tulumaks)
        {
            this.nimi = nimi;
            this.inimSugu = inimSugu;
            this.synniAasta = synniAasta;
            this.kaal = kaal;
            this.amet = amet;
            this.tulumaks = tulumaks;
            this.tulumaks = tulumaks;
        }

        public Tootaja(Tootaja totaja)
        {
            this.nimi = totaja.nimi;
            this.inimSugu = totaja.inimSugu;
            this.synniAasta = totaja.synniAasta;
            this.kaal = totaja.kaal;
            this.amet = totaja.amet;
            this.maksuvaba = totaja.maksuvaba;
            this.tulumaks = totaja.tulumaks;
        }
        public double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            double netopalk = ((palk - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            return netopalk;
        }

        public override void print_Info()
        {
            Console.WriteLine("See on {0}, {1}, ja ta on {2} sünniaasta, tema kaal on {3},ta töötab {4}, tema palk on {5} ja tulumaks on {6}", nimi, inimSugu, synniAasta, kaal, amet, palk, tulumaks);
        }
    }
}
