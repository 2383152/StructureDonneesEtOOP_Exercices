using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept02
{
    internal class CompteEpargne:CompteBancaire
    {
        double tauxEpargne; 

        public CompteEpargne(double tauxEpargne, string nom, string prenom):base(nom, prenom) 
        {
            this.tauxEpargne = tauxEpargne;
        }

        //affiche les informtion du compte épargne
        public void AfficherInfo()
        {
            //Console.WriteLine($"Nom: {Nom}");
            //Console.WriteLine($"Prenom: {Prenom}");
            //Console.WriteLine($"Numero: {Numero}");

            base.AfficherInfoCompte();
            Console.WriteLine($"Taux Epargne: {tauxEpargne}");
        }
    }
}
