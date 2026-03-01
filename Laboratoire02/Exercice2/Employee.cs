using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    internal class Employee
    {
        //Propriétés c'est écrit avec une lettre majuscule
        public string Nom { get; set; }


        //apparamen il faut rajouter des affaires, mais je comprends pas tant pk
        public double Salaire { get => salaire; set => salaire = value; }

        //On va le déclarer différement pour pouvoir y accédé dans AfficherInfo
        //public DateTime DateEmbauche { get; set; }

        DateTime DateEmbauche;
        double salaire;

        public int anneesService
        {
            //méthode pour calculer les années de services
            get
            {
                //le type serait var, pcq ca va données une variable qui n'est pas de type dateTime, mais le program ne sait pas encore ca sera de quel type
                var tempsService = DateTime.Now - DateEmbauche;

                //ce calcul permet d'obtenir le nombre de jour contenue dans tempsService puis on le divise par 365 pour obtenir un nombre d'années
                return tempsService.Days / 365;
            }

            set { }
        }

        //Constructeur
        public Employee(string nom, double salaire, DateTime dateEmbauche)
        {
            this.Nom = nom;
            this.Salaire = salaire;
            this.DateEmbauche = dateEmbauche;
        }

        public void AfficherInfo()
        {
            Console.WriteLine("Nom de l'employée: " + Nom);
            Console.WriteLine("Salaire: " + Salaire);
            Console.WriteLine("Nombre d'années de service: " + anneesService);
        }
    }
}
