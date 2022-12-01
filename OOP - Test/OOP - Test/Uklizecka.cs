using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Test
{
    class Uklizecka
    {
        public string jmeno;
        public string prijmeni;
        private bool sacek = false;
        public int volnemisto = 20;
        public int Vek { get; }
        public int Pohlavi { get; }
        public Uklizecka()
        {

        }

        public Uklizecka(string jmeno, string prijmeni, int vek)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            Vek = vek;
        }

        public string VynesKos(int volnemisto = 20)
        {
            if (volnemisto < 20)
            {
                return "Koš není potřeba vynášet, stále v něm nějaké místo je!";
            }
            else
            {
                return "Koš byl vynesen.";
                volnemisto = 20;
                sacek = false;
            }
        }
        public string DejSacek()
        {
            if(sacek == false)
            {
                return "Do koše byl dán nový sáček.";
                sacek = true;
            }
            else 
            {
                return "V koši už sáček je!";
            }
        }
        public override string ToString()
        {
            return this.jmeno + this.prijmeni + this.Vek + VynesKos(volnemisto) + DejSacek();
        }
    }
}
