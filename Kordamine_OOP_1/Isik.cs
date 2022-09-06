using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    abstract class Isik
    {
        public string nimi;
        public enum sugu { mees, naine };
        public sugu inimSugu;
        public int synniAasta;
        public int kaal;

        public Isik()
        { }

        public Isik(string nimi, sugu inimSugu, int synniAasta, int kaal)
        {
            this.nimi = nimi;
            this.inimSugu = inimSugu;
            this.synniAasta = synniAasta;
            this.kaal = kaal;
        }

        public abstract void print_Info();

        public void muuda_Sugu(sugu uusSugu) { inimSugu = uusSugu; }
        public void muuda_Nimi(string uusNimi) { nimi = uusNimi; }
        public int arvutaVanus()
        {
            int aastaNuud = DateTime.Now.Year;
            int vanus = aastaNuud - synniAasta;
            return vanus;
        }
       

    }

    


}
