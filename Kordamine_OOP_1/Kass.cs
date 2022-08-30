using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    class Kass : Koduloom
    {
        public string toug; //poroda
        public Kass(Kass loom)
        {
            this.toug = loom.toug;
            this.nimi = loom.nimi;
            this.varv = loom.varv;
            this.loomaSugu = loom.loomaSugu;
            this.kaal = loom.kaal;
            this.vanus = loom.vanus;
            this.elav = loom.elav;
        }
        public Kass(string toug, string nimi, string varv, sugu loomaSugu, double kaal, int vanus, bool elav) :base(nimi,varv,loomaSugu,kaal,vanus,elav)
        {
            this.toug = toug;
            
        }
        public override void print_Info()
        {
            //string elav1 = "";

            /*if (sugu== 'E')
            {
                if (elav == true)
                {
                    Console.WriteLine("Elav {0} {1} {2} ta on emane ja teema kaal on {4} ja ta on {5} aastat vana", toug, elav, varv, nimi, loomaSugu, kaal, vanus);
                    //elav1 = "Elav";
                }
                else
                {
                    Console.WriteLine("Surnud {0} {1} {2} ta on emane ja teema kaal on {4} ja ta on {5} aastat vana", toug, elav, varv, nimi, loomaSugu, kaal, vanus);
                    //elav1="Surnud";
                }
            }
            else if (sugu=='I')
            {
                if (elav == true)
                {
                    Console.WriteLine("Elav {0} {1} {2} ta on isane ja teema kaal on {4} ja ta on {5} aastat vana", toug, elav, varv, nimi, loomaSugu, kaal, vanus);
                    //elav1 = "Elav";
                }
                else
                {
                    Console.WriteLine("Surnud {0} {1} {2} ta on isane ja teema kaal on {4} ja ta on {5} aastat vana", toug, elav, varv, nimi, loomaSugu, kaal, vanus);
                    //elav1="Surnud";
                }
            }*/




        }

    }
}
