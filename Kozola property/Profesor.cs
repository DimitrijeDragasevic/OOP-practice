using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzola_property
{
    class Profesor:Osoba
    {

        public string _predmet_koji_predaje;

        public Profesor(string Ime, string Prezime, string predmet_koji_predaje):base(Ime,Prezime)
        {

            _predmet_koji_predaje = predmet_koji_predaje;

        }
        public string Predmet_koji_predaje
        {
            get { return _predmet_koji_predaje; }
            set { _predmet_koji_predaje = value; }

        }
        public override void Stampa()
        {
            base.Stampa();
            Console.WriteLine("Predmet koji predaje: {0}", this._predmet_koji_predaje);
        }

    }
}
