using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    abstract class Koduloom
    {
        public string nimi;
        public string varv;
        //public char sugu;
        public enum sugu { isane,emane};
        public sugu loomaSugu;
        public double kaal;
        public int vanus;
        public bool elav;//kui true , siis elav; kui false, siis on surnud
        public Koduloom()
        { }
        public Koduloom(string nimi, string varv, sugu loomaSugu, double kaal = 0.0, int vanus = 0, bool elav = true)
        {
            this.nimi = nimi;
            this.varv = varv;
            this.loomaSugu = loomaSugu;
            this.kaal = kaal;
            this.vanus = vanus;
            this.elav = elav;
        }

        public Koduloom(Koduloom loom) //klonimiseks
        {
            this.nimi = loom.nimi;
            this.varv = loom.varv;
            this.loomaSugu = loomaSugu;
            this.kaal = loom.kaal;
            this.vanus = loom.vanus;
            this.elav = loom.elav;
        }

        public abstract void print_Info();

        /*public void print_Info()
        {
            //string elav1 = "";
            if (sugu=='E')
            {
                if (elav == true)
                {
                    Console.WriteLine("Elav {1} {2} ta on emane ja teema kaal on {4} ja ta on {5} aastat vana", elav, varv, nimi, sugu, kaal, vanus);
                    //elav1 = "Elav";
                }
                else
                {
                    Console.WriteLine("Surnud {1} {2} ta on emane ja teema kaal on {4} ja ta on {5} aastat vana", elav, varv, nimi, sugu, kaal, vanus);
                    //elav1="Surnud";
                }
            }
            else if (sugu=='I')
            {
                if (elav == true)
                {
                    Console.WriteLine("Elav {1} {2} ta on isane ja teema kaal on {4} ja ta on {5} aastat vana", elav, varv, nimi, sugu, kaal, vanus);
                    //elav1 = "Elav";
                }
                else
                {
                    Console.WriteLine("Surnud {1} {2} ta on isane ja teema kaal on {4} ja ta on {5} aastat vana", elav, varv, nimi, sugu, kaal, vanus);
                    //elav1="Surnud";
                }
            }
            
            
            //Console.WriteLine("{0} {1} {2} ta on  {3} ja teema kaal on {4} ja ta on {5} aastat vana", elav1, varv, nimi, sugu, kaal, vanus);

        }*/
        public void muuda_Nimi(string uusNimi) { nimi = uusNimi; }
        public void muuda_Sugu(sugu uusSugu) { loomaSugu= uusSugu; }
        public void muuda_Elav(bool uusElav) { elav = uusElav; }
    }
}
