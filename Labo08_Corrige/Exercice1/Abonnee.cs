using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    internal class Abonnee
    {
        public int Identification { get; }
        public string Nom { get; }
        public string Prenom { get; }
        public string Email { get; }

        //attribut provenant de la relation entre abonnee et emprunt
        List<Emprunt> emprunts;

        //Constructeur
        public Abonnee(int id, string nom, string prenom, string email)
        {
            Identification = id;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            emprunts = new List<Emprunt>(); //Allocation mémoire pour la liste des emprunts          
        }

        public bool PeutEmprunter()
        {
            if (emprunts.Count < 3)
                return true;

            else return false;
        }

        //Méthode qui ajoute un emprunt dans la liste des emprunts de l'abonnee
        public void AjouterEmprunt(Emprunt emprunt)
        {
            if (PeutEmprunter())
                emprunts.Add(emprunt);
            else
                Console.WriteLine("L'abonnée a déjà emprunté 3 livres!");
        }

        //Méthode qui permet de retourner un livre
        public void RetournerLivre(Livre livre)
        {
            Emprunt empruntToReturn = null;

            //recherche le livre a retourner dans la liste des emprunts de l'abonne
            for(int i = 0; i < emprunts.Count; i++)
            {
                if (emprunts[i].LivreEmprunter.Titre == livre.Titre)
                {
                    empruntToReturn = emprunts[i];
                    break; //arrete la boucle dès qu'on trouve l'emprunt
                }
            }

            if (empruntToReturn != null)
            {
                empruntToReturn.DateRetourEffective = DateTime.Now;
                emprunts.Remove(empruntToReturn); //supprime le livre dans la liste d'emprunt

                Console.WriteLine($"Le livre {livre.Titre} a été retourné!");
            }
            else
            {
                Console.WriteLine("Ce livre n'a pas été emprunté par cet abonnée");
            }
        }
    }
}
