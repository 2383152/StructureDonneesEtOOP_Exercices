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
        private string Fonction {  get; set; }

        Systeme systeme = new Systeme();

        public Scientifique(string idObservateur)
        {
            systeme.ChargerDonnees("Donnees.csv");

            string[,] donneesObservateur = systeme.tableau;

            for (int i = 0; i < donneesObservateur.GetLength(0); i++)
            {
                for (int j = 0; j < donneesObservateur.GetLength(1); j++)
                {
                    if (donneesObservateur[i, j] == idObservateur)
                    {
                        numeroIdentification = donneesObservateur[i, 0];
                        Nom = donneesObservateur[i, 1];
                        DateNaissance = new DateTime(2023, 05, 03); //DateTime.Parse(donneesObservateur[i, 2]);
                        Matricule = donneesObservateur[i, 3];
                        Fonction = donneesObservateur[i, 4];

                        break;
                    }
                }
            }
        }

        public override void AfficherInfo()
        {
            Console.WriteLine("Information sur le scientifique recherché: ");
            Console.WriteLine("Numéro de matricule: " + Matricule);
            Console.WriteLine("Nom: " + Nom); //a retravaillé nom vs prénom
            Console.WriteLine("Date de naissance: " + DateNaissance);
            Console.WriteLine("Nom des missions affectés: " + Matricule);

            /*
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Profil Scientifique: ");
            Console.WriteLine("        Numero matricule: " + Matricule);
            Console.WriteLine("        Nom: " + Nom);
            Console.WriteLine("        Date de naissance: " + DateNaissance);
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
            */
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
