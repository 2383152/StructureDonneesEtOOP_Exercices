using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP_Synthese_2383152
{
    internal class Mission
    {
        private string NomMission {  get; set; }
        private string NumeroReference { get; set; }
        private string MatriculeScientifique { get; set; }
        private string Categorie {  get; set; }
        private string Destination { get; set; }
        private string VaiseauUtilise { get; set; }
        private int DureeEstimee { get; set; }
        private DateTime DateLancement { get; set; }

        private List<Scientifique> scientifiquesAssocies { get; set; }

        public Mission(string numReference)
        {
            Systeme systemeMission = new Systeme();
            systemeMission.ChargerDonnees("Donnees.csv");

            string[,] donneesMissions = systemeMission.tableau;

            for (int i = 0; i < donneesMissions.GetLength(0); i++)
            {
                for (int j = 0; j < donneesMissions.GetLength(1); j++)
                {
                    if (donneesMissions[i, j] == numReference)
                    {
                        NomMission = donneesMissions[i, 0];
                        NumeroReference = donneesMissions[i, 1];
                        MatriculeScientifique = donneesMissions[i, 2];
                        Categorie = donneesMissions[i, 3];
                        VaiseauUtilise = donneesMissions[i, 4];
                        DureeEstimee = 0; //int.Parse(donneesMissions[i, 5]);
                        DateLancement = new DateTime(2020, 04, 05);//DateTime.Parse(donneesMissions[i, 6]);

                        break;
                    }
                }
            }
        }

        public void AfficherInfo()
        {
            Console.WriteLine("Informations sur la mission");
            Console.WriteLine();
            Console.WriteLine("        Nom: " + NomMission);
            Console.WriteLine("        Numero de référence: " + NumeroReference);
            Console.WriteLine("        Categorie: " + Categorie);
            Console.WriteLine("        Destination: " + Destination);
            Console.WriteLine("        Vaiseau utilisé: " + VaiseauUtilise);
            Console.WriteLine("        Durée estimée: " + DureeEstimee);
            Console.WriteLine("        Date de lancement: " + DateLancement);
            Console.WriteLine("        Liste de scientifique associé: " + scientifiquesAssocies);
            Console.WriteLine();
        }


        
    }
}
