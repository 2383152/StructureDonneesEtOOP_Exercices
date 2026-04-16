using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    internal class Emprunt
    {
        public int Id { get; }
        public DateTime DateDebut { get; }
        public DateTime DateRetour { get; }
        public DateTime DateRetourEffective { get; set;  }

        //attributs provenant de la relation entre Emprunt et Abonne et Emprunt et Livre
        public Abonnee AbonneEmprunteur { get; }
        public Livre LivreEmprunter { get; }

        //Constructuer
        public Emprunt(int id, Abonnee abonnee, Livre livre)
        {
            //Vérifie la disponibilité du livre
            if(!livre.EstDisponible)
            {
                Console.WriteLine("Ce livre est déjà emprunté");
            }
            else
            {
                Id = id;
                AbonneEmprunteur = abonnee;
                LivreEmprunter = livre;
                DateDebut = DateTime.Now;
                DateRetour = DateDebut.AddDays(30);
                livre.EstDisponible = false
            }
        }
    }
}
