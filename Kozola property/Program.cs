using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzola_property
{
    class Program
    {
        static void Main(string[] args)
        {

            Student ucenik = new Student("Dimitrije","Dragasevic","2a2/0045/13","4");
            ucenik.Pol = Student.Polovi.Musko;
            ucenik.Stampa();
           
           
            Profesor profa = new Profesor("Marko", "Mandic", "Matematika");
            profa.Pol = Profesor.Polovi.Musko;
            profa.Stampa();

            Console.ReadKey();

        }
    }
}
