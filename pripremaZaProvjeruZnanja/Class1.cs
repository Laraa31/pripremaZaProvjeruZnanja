using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaZaProvjeruZnanja
{
    internal class Vozilo
    {
        String vrsta, marka, naziv;
        DateTime GodPro;
        int snaga;

        public Vozilo(string vrsta, string marka, string naziv, DateTime godPro, int snaga)
        {
            this.vrsta = vrsta;
            this.marka = marka;
            this.naziv = naziv;
            GodPro = godPro;
            this.snaga = snaga;
        }

        public string Vrsta { get => vrsta; set => vrsta = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public DateTime GodPro1 { get => GodPro; set => GodPro = value; }
        public int Snaga { get => snaga; set => snaga = value; }

        public override string ToString()
        {
            String ispis="Vrsta: "+this.Vrsta+ "   Marka: "+ this.Marka+"   Naziv: "
                +this.Naziv+"   Godina proizvodnje: "+ this.GodPro.Year 
                +"   Snaga: "+ this.Snaga+" KS";   
            return ispis;
        }
    }
}
