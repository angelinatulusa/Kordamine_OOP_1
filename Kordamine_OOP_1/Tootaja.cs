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
        public int maksuvaba;
        public int tulumaks;
        public string asutus;

        public Tootaja(string nimi, sugu inimSugu, int synniAasta, int kaal, string amet, int palk, int maksuvaba, int tulumaks, string asutus): base(nimi, inimSugu, synniAasta, kaal)
        {
            this.nimi = nimi;
            this.inimSugu = inimSugu;
            this.synniAasta = synniAasta;
            this.kaal = kaal;
            this.amet = amet;
            this.palk= palk;    
            this.tulumaks = tulumaks;
            this.maksuvaba = maksuvaba;
            this.asutus = asutus;
        }

        public Tootaja(Tootaja totaja)
        {
            this.nimi = totaja.nimi;
            this.inimSugu = totaja.inimSugu;
            this.synniAasta = totaja.synniAasta;
            this.kaal = totaja.kaal;
            this.amet = totaja.amet;
            this.palk = totaja.palk;
            this.maksuvaba = totaja.maksuvaba;
            this.tulumaks = totaja.tulumaks;
            this.asutus = totaja.asutus;
        }
        public double arvutaSissetulek(double maksuvaba, double tulumaks, double palk)
        {
            double netopalk = ((palk - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            return netopalk;
        }

        public override void print_Info()
        {
            Console.WriteLine($"See on {nimi}, {inimSugu}, ja ta on {synniAasta} sünniaasta, tema kaal on {kaal},ta töötab {amet}ks {asutus}es, tema palk on {arvutaSissetulek(maksuvaba,tulumaks,palk)}");
        }
    }
}
