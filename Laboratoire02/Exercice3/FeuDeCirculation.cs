using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    internal class FeuDeCirculation
    {
        public string Couleur {  get; set; }
        public double NbSecondes { get; set; }

        public FeuDeCirculation(string couleur, double nbSecondes)
        {
            this.Couleur = couleur;
            this.NbSecondes = nbSecondes;
        }

        //Méthode pour changer la couleur
        public string ChangerCouleurRouge()
        {
            return Couleur = "rouge";
        }

        public string ChangerCouleurJaune()
        {
            return Couleur = "jaune";
        }

        public string ChangerCouleurVert()
        {
            return Couleur = "vert";
        }

        //Méthode pour vérifier la couleur du feux
        public bool EstCouleurVerte()
        {
            if (Couleur == "vert")
                return true;
            else
                return false;
        }

        public bool EstCouleurRouge()
        {
            if (Couleur == "rouge")
                return true;
            else
                return false;
        }
    }
}
