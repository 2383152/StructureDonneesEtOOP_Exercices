using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03
{
    internal class FeuDeCirculation
    {
        public string Couleur { get; set; }
        public int Duree { get; set; }

        public FeuDeCirculation(string Couleur, int Duree)
        {
            this.Couleur = Couleur;
            this.Duree = Duree;
        }
        // Méthode pour vérifier si le feu est rouge
        public bool EstRouge()
        {
            return Couleur == "Rouge";

        }
        public bool EstVert()
        {
            return Couleur == "Vert";
        }
        // Méthode pour changer la couleur du feu de circulation
        public void ChangerCouleurFeu(string NouvelleCouleur)
        {
            Couleur = NouvelleCouleur;
        }
    }
}
