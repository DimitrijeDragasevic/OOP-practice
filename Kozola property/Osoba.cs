using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzola_property
{
    class Osoba
    {
        public string _ime;
        public string _prezime;
        public Polovi _pol;


        public Osoba(string Ime, string Prezime)
        {
            _ime = Ime;
            _prezime = Prezime;
            _pol = Pol;
            

        }
        public string Ime

            {
            get { return _ime; }
            set { _ime = value;}

            }
        public string Prezime
        {
            get { return _ime; }
            set { _ime = value; }
        }
        public Polovi Pol
        {
            get
            {
                return _pol;
            }
            set
            {
                _pol = value;
            }
        }


        public enum Polovi
        {
            Musko,
            Zensko
        }
        public virtual void Stampa()
        {
            Console.WriteLine("ime: {0}", this._ime);
            Console.WriteLine("Prezime: {0}", this._prezime);

        }
    }
}
