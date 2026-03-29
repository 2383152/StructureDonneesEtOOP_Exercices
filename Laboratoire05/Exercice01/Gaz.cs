using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    internal class Gaz : EtatMatiere
    {

        public Gaz(string etat) : base(etat)
        {
        }

        public override EtatMatiere ChangerEtat(double temperature)
        {
            if (temperature < 0)
                return new Solide("solide");
            else if (temperature < 100)
                return new Liquide("liquide");
            else
                return this;
               
        }
    }
}
