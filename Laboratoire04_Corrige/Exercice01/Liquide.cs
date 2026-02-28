using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    internal class Liquide:ObjetPhysique
    {
        string couleur;

        public Liquide(double masse, double volume, double densite, string nomObjet, string couleur) : base(masse, volume, densite, nomObjet)
        {
            this.couleur = couleur;
        }
        public void AffichageInfoLiquide()
        {
            AfficherInfoObjetPhysique();
        }
    }
}
