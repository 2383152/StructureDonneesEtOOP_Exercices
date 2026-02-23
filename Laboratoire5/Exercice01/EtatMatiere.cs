using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    internal class EtatMatiere
    {
        string nom;
        public EtatMatiere(string nom)
        {
            this.nom = nom;
        }

        //Méthode pour changer l'état de la matière
        public virtual EtatMatiere ChangerEtat(double temperature)
        {
            return this; //PAr defaut
        }

        public void AfficherEtat()
        {
            Console.WriteLine($"L'état actuel est: {nom}");
        }
    }
}
