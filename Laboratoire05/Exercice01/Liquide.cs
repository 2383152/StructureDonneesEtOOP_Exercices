using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    internal class Liquide : EtatMatiere
    {
        public Liquide(string etat) : base(etat)
        {
        }

        public override EtatMatiere ChangerEtat(double temperature)
        {
            if (temperature <= 0) 
            {
                return new Solide("solide");

                /* my attempt (was pretty close):
                 * return new EtatMatiere("solide");
                 */
            }

            else if (temperature >= 100)
                return new Gaz("gazeux");

            else
                return this;
        }
    }
}
