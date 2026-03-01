using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    internal class Employee
    {
        public string Nom { get; set; } // string nom (vesion rapide)
        public double Salaire { get => salaire; set => salaire = value; } // Déclaration et definition de la propriété (clic droit, action rapide, champ ...)
        public DateTime DateEmbauche { get => dateEmbauche; set => dateEmbauche = value; }

        DateTime dateEmbauche;
        double salaire;

        // Definition du constructeur 

        public Employee(string Nom, double Salaire, DateTime DateEmbauche)
        {
            this.Nom = Nom;
            this.Salaire = Salaire;
            this.DateEmbauche = DateEmbauche;
        }
        // version 1 affichage
        public string AfficherValeur()
        {
            return "Nom: " + Nom + "\nSalaire: " + Salaire + "\nDate d'embauche: " + dateEmbauche;
        }
        public int CalculerAnneeService()
        {
            return DateTime.Now.Year - dateEmbauche.Year;
        }
    }
}
