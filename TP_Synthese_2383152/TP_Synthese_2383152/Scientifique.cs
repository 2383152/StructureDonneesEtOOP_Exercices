using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Synthese_2383152
{
    internal class Scientifique : Utilisateur
    {
        private string Matricule {  get; set; }

        public override void AfficherInfo()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Profil Scientifique: ");
            Console.WriteLine("        Numero matricule: ");
            Console.WriteLine("        Nom: ");
            Console.WriteLine("        Date de naissance");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Résumé profil");
            Console.WriteLine();
            Console.WriteLine("        Total des missions affectées: ");
            Console.WriteLine("        Catégorie Planète: ");
            Console.WriteLine("        Catégorie Étoile: ");
            Console.WriteLine("        Catégorie Satélite: ");
            Console.WriteLine();
        }

        public void AjouterMission(Mission mission)
        {

        }

        public void SupprimerMission(Mission mission)
        {

        }

        public void AjouterInstrument()
        {

        }

        public void AjouterObjetCeleste()
        {

        }

        public void AjouterObservateur(Observateur observateur)
        {

        }

        public void AjouterScientifique(Scientifique scientifique)
        {

        }
    }
}
