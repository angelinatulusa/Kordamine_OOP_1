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
        public double toetus;
        public int toetus2;
        public int opilaspilet;
        public int lapsed_peres;
        public Kutsekooliopilane(string nimi, sugu inimSugu, int synniAasta, int kaal, string eriala, int kursus, double toetus, int toetus2, int lapsed_peres)
        {
            this.nimi = nimi;
            this.inimSugu = inimSugu;
            this.synniAasta = synniAasta;
            this.kaal = kaal;
            this.eriala = eriala;
            this.kursus = kursus;
            this.toetus = toetus;
            this.toetus2 = toetus2;
            this.lapsed_peres = lapsed_peres;
        }

        public Kutsekooliopilane(Kutsekooliopilane kutsekooliopilane)
        {
            this.nimi = kutsekooliopilane.nimi;
            this.inimSugu = kutsekooliopilane.inimSugu;
            this.synniAasta = kutsekooliopilane.synniAasta;
            this.kaal = kutsekooliopilane.kaal;
            this.eriala = kutsekooliopilane.eriala;
            this.kursus = kutsekooliopilane.kursus;
            this.toetus = kutsekooliopilane.toetus;
            this.toetus2 = kutsekooliopilane.toetus2;
            this.lapsed_peres = kutsekooliopilane.lapsed_peres;
        }
        public void eelarve()
        {
            if (lapsed_peres==1)
            {
                 opilaspilet = 1;
            }
            else if (lapsed_peres == 2)
            {
                 opilaspilet = 3;
            }
            else
            {
                 opilaspilet = 5;
            }
        }
        public void print_Info2()
        {
            if (toetus2==1)
            {
                Console.WriteLine($"See on {0}, {1}, ja ta on {2} sünniaasta, tema kaal on {3},ta õpib {4} kursustel, ta õpib {5}ks, tema toetus on {6} eurot", nimi, inimSugu, synniAasta, kaal, kursus, eriala, toetus);
            }
            else if (toetus2==2)
            {
                Console.WriteLine("See on {0}, {1}, ja ta on {2} sünniaasta, tema kaal on {3},ta õpib {4} kursustel, ta õpib {5}ks, ta ei saa toetusi", nimi, inimSugu, synniAasta, kaal, kursus, eriala);
            }
            else
            {
                Console.WriteLine();
            }
        }

        public override void print_Info()
        {
            Console.WriteLine("See on {0}, {1}, ja ta on {2} sünniaasta, tema kaal on {3},ta õpib {4} kursustel, ta õpib {5}ks, tema toetus on {6} eurot", nimi, inimSugu, synniAasta, kaal, kursus, eriala, toetus );
        }

        public void muuda_eriala(string uusEriala)
        {
            eriala = uusEriala;
            kursus = 1;
        }

        public void muuda_toetusi(int uusToetus)
        {
            toetus2 = uusToetus;
        }
    }
}
