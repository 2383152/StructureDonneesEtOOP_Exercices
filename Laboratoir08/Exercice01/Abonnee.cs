using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    internal class Abonnee
    {
        private int id;
        private string nom;
        private string prenom;
        private string email;

        List<Emprunt> listEmprunts = new List<Emprunt>();

        public bool peutEmprunter()
        {
            
        }

        public void AjouterEmprunt(Emprunt emprunt)
        {
            listEmprunts.Add(emprunt);
        }

        public void RetournerLivre (Livre livre)
        {

        }
    }
}
