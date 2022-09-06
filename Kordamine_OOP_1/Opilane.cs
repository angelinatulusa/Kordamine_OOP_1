using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    class Opilane : Isik
    {
        public int klass;
        public string koolinimi;
        public string tulemused;

        public Opilane(string nimi, sugu inimSugu, int synniAasta, int kaal,int klass,string koolinimi, string tulemused):base(nimi, inimSugu, synniAasta, kaal)
        {
            this.nimi = nimi;
            this.inimSugu = inimSugu;
            this.synniAasta = synniAasta;
            this.kaal = kaal;
            this.klass = klass;
            this.koolinimi = koolinimi;
            this.tulemused = tulemused;
        }

        public Opilane(Opilane opilane)
        {
            this.nimi = opilane.nimi;
            this.inimSugu = opilane.inimSugu;
            this.synniAasta = opilane.synniAasta;
            this.kaal = opilane.kaal;
            this.klass = opilane.klass;
            this.koolinimi = opilane.koolinimi;
        }

        public override void print_Info()
        {
            Console.WriteLine("See on {0}, {1}, ja ta on {2} sünniaasta, tema kaal on {3},ta õpib {4} klassis, {5} gümnaasiumis ja tal on {6} tulemused",nimi,inimSugu,synniAasta,kaal,klass, koolinimi, tulemused);
        }
        
    }
}
