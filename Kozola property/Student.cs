using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzola_property
{
    class Student:Osoba
    {
        public string _broj_indeska;
        public string _broj_polozenih_ispita;

        public Student( string Ime, string Prezime,string broj_idenksa, string broj_polozenih_ispita):base(Ime,Prezime)
        {
            
            _broj_indeska = broj_idenksa;
            _broj_polozenih_ispita = broj_polozenih_ispita;
        
        
        }

        public string Broj_indeksa
        {
            get { return _broj_indeska; }
            set { _broj_indeska = value; }

        }
        
        public string Broj_polozenih_ispita
        {
            get { return _broj_polozenih_ispita; }
            set { _broj_polozenih_ispita = value; }

        }
        public override void Stampa()
        {
            base.Stampa();
            Console.WriteLine("Broj indeksa je:{0}", this.Broj_indeksa);
            Console.WriteLine("Broj polozenih ispita je:{0}", this.Broj_polozenih_ispita);
        }


    }
    }

