using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    internal class Liquide:EtatMatiere
    {
        public Liquide():base("Liquide")
        {

        }

        //Redéfinition de la méthode
        public override EtatMatiere ChangerEtat(double temperature)
        {
            if(temperature < 0)//Solidification
            {
                Console.WriteLine("Le liquide gèle et devient solide");
                return new Solide();
            }
            else if(temperature >= 100) //Vaporisarion
            {
                Console.WriteLine("Le liquide s'évapore et devient un gaz");
                return new Gaz();
            }
            return this;//reste un liquide

        }
    }
}
