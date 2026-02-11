using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercice01
{
    internal class Valeurs
    {
        List <double> temps = new List<double>();
        List <double> hauteurs = new List<double>();
        List <double> vitesse = new List<double> { 0 }; //vitesse initiale est a 0

        //Méthode pour calculer la vitesse
        public void CalculerVitesse()
        {
            for(int i = 1; i < temps.Count; i++)
            {
                double dt = temps[i] - temps[i - 1]; //intervalle de temps
                double dh = hauteurs[i - 1] - hauteurs[i]; //différence de hauteur

                if(dt > 0)
                {
                    double resultatVitesse = dh / dt;
                    vitesse.Add(resultatVitesse);
                }
            }
        }



        //Méthode pour lire les données du fichier (Donnees.csv) et les sauvegarder en mémoire

        public void LectureFichier()
        {
            StreamReader fichier = new StreamReader("Donnees.csv"); //Ouverture du fichier en lecture
            fichier.ReadLine(); //Ignore la ligne d'entete

            string ligne; //déclare une chaine de caractères

            while ((ligne = fichier.ReadLine()) != null)//extraction d'une ligne et vérifie si elle est vide
            {
                string[] donnees = ligne.Split(';'); //fractionne la chaine de caractères
                temps.Add(double.Parse(donnees[0]));
                hauteurs.Add(double.Parse(donnees[1]));
            }
        }

        //Méthode pour sauvegarder dans le fichier
        public void EcritureFichier()
        {
            StreamWriter fichierSorti = new StreamWriter("Resultat.csv");

            //Première ligne du fichier
            fichierSorti.WriteLine("temps (s); hauteur (m); vitesse (m/s)");

            for(int i = 0; i < temps.Count; i++)
            {
                fichierSorti.WriteLine($"{temps[i]};{hauteurs[i]};{vitesse[i]}");
            }

            fichierSorti.Close();


            Console.WriteLine("Résultats enregistrés dans le fichier Resultat.csv");

        }

    }
}
