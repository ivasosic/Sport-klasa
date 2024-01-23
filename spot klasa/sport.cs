using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spot_klasa
{
    internal class sport
    {
        String naziv;
        Boolean IgraliseLoptom;
        int BrojIgraca;

        public string Naziv { get => naziv; set => naziv = value; }
        public bool IgraliseLoptom1 { get => IgraliseLoptom; set => IgraliseLoptom = value; }
        public int BrojIgraca1 { get => BrojIgraca; set => BrojIgraca = value; }

        public sport(string naziv, bool igraliseLoptom, int brojIgraca)
        {
            this.naziv = naziv;
            IgraliseLoptom = igraliseLoptom;
            BrojIgraca = brojIgraca;
        }

        public override string ToString()
        {
            string str = "\nNaziv sporta: " + naziv + "\n Igrali se loptom: "+IgraliseLoptom+ "\n Broj igrača: " +BrojIgraca;
            return str;
        }
    }
    
    

}
