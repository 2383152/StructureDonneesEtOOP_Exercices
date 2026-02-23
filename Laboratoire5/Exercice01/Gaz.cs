using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    internal class Gaz:EtatMatiere
    {
        public Gaz():base("Gaz")
        {

        }

        //Redefinition de la méthode pour changer l'état de la matière
        public override EtatMatiere ChangerEtat(double temperature)
        {
            if (temperature < 100) //condensation
            {
                Console.WriteLine("Le solide fond et devient liquide");
                return new Liquide();
            }
            return this; //Rreste un gaz
        }
    }
}
