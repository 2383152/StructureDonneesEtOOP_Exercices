using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    internal class Solide:ObjetPhysique
    {
        string forme;

        public Solide(double masse, double volume, double densite, string nomObjet, string forme):base(masse, volume, densite, nomObjet)
        {
            this.forme = forme;
        }
        public void AffichageInfoSolide()
        {
            AfficherInfoObjetPhysique();
        }
    }
}
