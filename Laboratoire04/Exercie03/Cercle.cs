using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercie03
{
    internal class Cercle : CorpsEnMouvement
    {
        public double Rayon {  get; set; }

        public Cercle(double Rayon, double positionX, double positionY, double vitesse) : base(positionX, positionY, vitesse)
        {
            this.Rayon = Rayon;
        }

        public void AfficherEtat()
        {
            Console.WriteLine("Cercle");
            Console.WriteLine("Rayon: " + Rayon);

            //si ils ont tous le mm nom, on ferait base.methode(), sinon ca bug fucking
            base.AfficherEtat();
        }
    }
}
