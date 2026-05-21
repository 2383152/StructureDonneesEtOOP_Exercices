using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Synthese_2383152
{
    internal class Utilisateur
    {
        protected string Nom { get; set; }
        protected string Prenom { get; set; }
        protected DateTime DateNaissance { get; set; }
        protected string Adresse { get; set; }

        /*
        public Utilisateur (string nom, string prenom, DateTime dateNaissance, string adresse)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Adresse = adresse;
        }
        */

        public virtual void AfficherInfo() { }
        
    }
}
