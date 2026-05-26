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

        Systeme systemeDonnees = new Systeme();
        Systeme systemeObjetMission = new Systeme();
        Systeme systemeInstrument = new Systeme();

        public Scientifique(string idObservateur)
        {
            systemeDonnees.ChargerDonnees("Donnees.csv");
            systemeObjetMission.ChargerDonnees("ObjetMission.csv");
            systemeInstrument.ChargerDonnees("InstrumentMesures.csv");

            string[,] donneesObservateur = systemeDonnees.tableau;

            string[,] donneesMisison = systemeObjetMission.tableau;

            string[,] donneesInstrument = systemeInstrument.tableau;

            for (int i = 0; i < donneesObservateur.GetLength(0); i++)
            {
                for (int j = 0; j < donneesObservateur.GetLength(1); j++)
                {
                    if (donneesObservateur[i, 3] == idObservateur)
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

        public void AfficherInfo()
        {
            Console.WriteLine("Information sur le scientifique recherché: ");
            Console.WriteLine("Numéro de matricule: " + Matricule);
            Console.WriteLine("Nom: " + Nom); //a retravaillé nom vs prénom
            Console.WriteLine("Date de naissance: " + DateNaissance);
            Console.WriteLine("Nom des missions affectés: " + Matricule);

        }

        public override void AfficherProfil()
        {
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
        }

        public void AjouterObservateur()
        {
            List<string> doneesObservateur = new List<string>();
            Console.WriteLine("Inscrir les informations suivantes sur l'observateur:");

            Console.Write("Numero identification: ");
            doneesObservateur.Add(Console.ReadLine() + ";");

            Console.Write("Nom complet: ");
            doneesObservateur.Add(Console.ReadLine() + ";");

            Console.Write("Date de naissance (AAAA-MM-JJ): ");
            doneesObservateur.Add(Console.ReadLine() + ";;;;");

            systemeDonnees.SauvegarderDonnees(doneesObservateur, "Donnees.csv");

            systemeDonnees.ChargerDonnees("Donnees.csv");

        }

        public void AjouterScientifique()
        {
            List<string> doneesObservateur = new List<string>();
            Console.WriteLine("Inscrir les informations suivantes sur l'observateur:");

            Console.Write("Numero identification: ");
            doneesObservateur.Add(Console.ReadLine() + ";");

            Console.Write("Nom complet: ");
            doneesObservateur.Add(Console.ReadLine() + ";");

            Console.Write("Date de naissance (AAAA-MM-JJ): ");
            doneesObservateur.Add(Console.ReadLine() + ";");

            Console.Write("Matricule: ");
            doneesObservateur.Add(Console.ReadLine() + ";");

            Console.Write("Fonction: ");
            doneesObservateur.Add(Console.ReadLine() + ";;");

            systemeDonnees.SauvegarderDonnees(doneesObservateur, "Donnees.csv");

            systemeDonnees.ChargerDonnees("Donnees.csv");
        }

        public void AjouterMission()
        {
            List<string> donneesMisison = new List<string>();
            Console.WriteLine("Inscrir les informations suivantes sur la mission:");

            Console.Write("Nom de la mission: ");
            donneesMisison.Add(Console.ReadLine() + ";");

            Console.Write("Numéro de référence: ");
            donneesMisison.Add(Console.ReadLine() + ";");

            Console.Write("Numéro de matricule scientifique: ");
            donneesMisison.Add(Console.ReadLine() + ";");

            Console.Write("Catégorie: ");
            donneesMisison.Add(Console.ReadLine() + ";");

            Console.Write("Vaiseau spatial utilisé: ");
            donneesMisison.Add(Console.ReadLine() + ";");

            Console.Write("Durée estimé: ");
            donneesMisison.Add(Console.ReadLine() + ";");

            Console.Write("Date de lancement (AAAA-MM-JJ): ");
            donneesMisison.Add(Console.ReadLine() + ";");

            systemeObjetMission.SauvegarderDonnees(donneesMisison, "ObjetMission.csv");

            systemeObjetMission.ChargerDonnees("ObjetMission.csv");
        }

        public void SupprimerMission()
        {


        }

        public void AjouterInstrument()
        {
            List<string> donneesInstrument = new List<string>();
            Console.WriteLine("Inscrir les informations suivantes sur la mission:");

            Console.Write("Numero de référence de la mission: ");
            donneesInstrument.Add(Console.ReadLine() + ";");

            Console.Write("Nom de l'instrument: ");
            donneesInstrument.Add(Console.ReadLine() + ";");

            Console.Write("Numéro de matricule scientifique: ");
            donneesInstrument.Add(Console.ReadLine() + ";");

            Console.Write("Catégorie: ");
            donneesInstrument.Add(Console.ReadLine() + ";");

            Console.Write("Vaiseau spatial utilisé: ");
            donneesInstrument.Add(Console.ReadLine() + ";");

            Console.Write("Durée estimé: ");
            donneesInstrument.Add(Console.ReadLine() + ";");

            Console.Write("Date de lancement (AAAA-MM-JJ): ");
            donneesInstrument.Add(Console.ReadLine() + ";");

            systemeInstrument.SauvegarderDonnees(donneesInstrument, "Donnees.csv");

            systemeInstrument.ChargerDonnees("Donnees.csv");
        }

        public void AjouterObjetCeleste()
        {
            List<string> donneesMisison = new List<string>();
            Console.WriteLine("Inscrir les informations suivantes sur la mission:");

            Console.Write("Nom de la mission: ");
            donneesMisison.Add(Console.ReadLine() + ";");

            Console.Write("Numéro de référence: ");
            donneesMisison.Add(Console.ReadLine() + ";");

            Console.Write("Numéro de matricule scientifique: ");
            donneesMisison.Add(Console.ReadLine() + ";");

            Console.Write("Catégorie: ");
            donneesMisison.Add(Console.ReadLine() + ";");

            Console.Write("Vaiseau spatial utilisé: ");
            donneesMisison.Add(Console.ReadLine() + ";");

            Console.Write("Durée estimé: ");
            donneesMisison.Add(Console.ReadLine() + ";");

            Console.Write("Date de lancement (AAAA-MM-JJ): ");
            donneesMisison.Add(Console.ReadLine() + ";");

            systemeObjetMission.SauvegarderDonnees(donneesMisison, "ObjetMission.csv");

            systemeObjetMission.ChargerDonnees("ObjetMission.csv");
        }

        

        
    }
}
