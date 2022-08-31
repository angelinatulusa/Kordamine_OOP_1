using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    class Kutsekooliopilane : Isik
    {
        public string eriala;
        public int kursus;
        public Kutsekooliopilane(string nimi, sugu inimSugu, int synniAasta, int kaal, string eriala, int kursus)
        {
            this.nimi = nimi;
            this.inimSugu = inimSugu;
            this.synniAasta = synniAasta;
            this.kaal = kaal;
            this.eriala = eriala;
            this.kursus = kursus;
        }

        public Kutsekooliopilane(Kutsekooliopilane kutsekooliopilane)
        {
            this.nimi = kutsekooliopilane.nimi;
            this.inimSugu = kutsekooliopilane.inimSugu;
            this.synniAasta = kutsekooliopilane.synniAasta;
            this.kaal = kutsekooliopilane.kaal;
            this.eriala = kutsekooliopilane.eriala;
            this.kursus = kutsekooliopilane.kursus;
        }

        public override void print_Info()
        {
            Console.WriteLine("See on {0}, {1}, ja ta on {2} sünniaasta, tema kaal on {3},ta õpib {4} kursustel, {5} ", nimi, inimSugu, synniAasta, kaal, kursus, eriala );
        }
    }
}
