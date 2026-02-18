using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept02
{
    internal class CompteBancaire
    {
        protected string Nom;
        protected string Prenom;
        public string Numero { get; set; }

        public CompteBancaire(string nom, string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }

        protected void AfficherInfoCompte()
        {
            Console.WriteLine($"Nom: {Nom}");
            Console.WriteLine($"Prenom: {Prenom}");
            Console.WriteLine($"Numero: {Numero}");
        }
    }
}
