using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Test
{
    class Clovek
    {
        public string jmeno;
        public string prijmeni;
        protected int volnemisto = 20;
        public int odpadky;
        public int Vek { get; }
        public int Pohlavi { get; }

        public Clovek()
        {

        }
        public Clovek(string jmeno, string prijmeni, int vek)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            Vek = vek;
        }

        public string VyhodOdpadky(int odpadky)
        {
            if(odpadky > volnemisto)
            {
                return " vyhodil pouze nejaké odpadky protože je koš plný";
            }
            else
            {
                return " vyhodil " + odpadky + " odpadků";
                volnemisto -= odpadky;
            }
        }

        public void OtevriKos()
        {

        }

        public override string ToString()
        {
            return this.jmeno + this.prijmeni + this.VyhodOdpadky(odpadky);
        }
    }
}
