using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Synthese_2383152
{
    internal class Observateur : Utilisateur
    {
        Systeme systemeDonnees = new Systeme();
        Systeme systemeInstrument = new Systeme();

        public Observateur (string idObservateur)
        {            
            systemeDonnees.ChargerDonnees("Donnees.csv");
            systemeInstrument.ChargerDonnees("InstrumentMesure.csv");

            string[,] donneesObservateur = systemeDonnees.tableau;

            for (int i = 0; i < donneesObservateur.GetLength(0); i++)
            {
                for (int j = 0; j < donneesObservateur.GetLength(1); j++)
                {
                    if (donneesObservateur[i, j] == idObservateur)
                    {
                        numeroIdentification = donneesObservateur[i, 0];
                        Nom = donneesObservateur[i, 1];
                        DateNaissance = new DateTime(2023, 05, 03); //DateTime.Parse(donneesObservateur[i, 2]);

                        break;
                    }
                }
            }
        }

        public override void AfficherProfil()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Profil Observateur: ");
            Console.WriteLine();
            Console.WriteLine("        Numero d'idendification: " + numeroIdentification);
            Console.WriteLine("        Nom: " + Nom);
            Console.WriteLine("        Date de naissance: " + DateNaissance);
            Console.WriteLine();
        }

        public bool RechercherDansFichier(string entree)
        {
            string[,] donneesMissions = systemeDonnees.tableau;

            for (int i = 0; i < donneesMissions.GetLength(0); i++)
            {
                for (int j = 0; j < donneesMissions.GetLength(1); j++)
                {
                    if (donneesMissions[i, j] == entree)
                    {
                        return true;
                        
                    }                 
                }
            }
           
            return false;
            
        }        

        public void AfficherListeMission() //a retravaillé
        {
            string[,] donneesFichier = systemeDonnees.tableau;

            Dictionary<int, List<string>> missions = new Dictionary<int, List<string>>();


            for (int i = 0; i < donneesFichier.GetLength(0); i++)
            {
                if (donneesFichier[i, 0].Contains("Mission"))
                {
                    List<string> donneesMission = new List<string>();

                    for (int j = 0; j < donneesFichier.GetLength(1); j++)
                    {
                        donneesMission.Add(donneesFichier[i, j]);
                    }

                    missions.Add(i, donneesMission);
                }

            }

            foreach(KeyValuePair<int, List<string>> element in missions)
            {
                Console.WriteLine();
                Console.WriteLine($"-Mission {element.Key}-");
                Console.WriteLine();

                foreach (string valeur in element.Value)
                {
                    Console.WriteLine(valeur);
                }

                Console.WriteLine();
                Console.WriteLine("Duree: ");
                Console.WriteLine();
            }
        }

        public void AfficherListeScientifique() //a retravaillé
        {
            string[,] donneesFichier = systemeDonnees.tableau;

            Dictionary<int, List<string>> scientifiques = new Dictionary<int, List<string>>();


            for (int i = 0; i < donneesFichier.GetLength(0); i++)
            {
                //if (donneesFichier[i, donneesFichier.GetLength(1) - 1].Contains(";;;"))
                {
                    List<string> donneesScientifique = new List<string>();

                    for (int j = 0; j < donneesFichier.GetLength(1); j++)
                    {
                        donneesScientifique.Add(donneesFichier[i, j]);
                    }

                    scientifiques.Add(i, donneesScientifique);
                }

            }

            foreach (KeyValuePair<int, List<string>> element in scientifiques)
            {
                Console.WriteLine();
                Console.WriteLine($"-Scientifique {element.Key}-");
                Console.WriteLine();

                foreach (string valeur in element.Value)
                {
                    Console.WriteLine(valeur);
                }
            }
        }

    }
}
