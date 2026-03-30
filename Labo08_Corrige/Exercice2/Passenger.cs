using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    internal class Passenger
    {
        string nom;
        int age;

        //Définition des méthodes
        public void Ambarquer()
        {
            Console.WriteLine($"{nom} embarque a bord");
        }

        public void Desembarquer()
        {
            Console.WriteLine($"{nom} débarque");
        }
    }
}
