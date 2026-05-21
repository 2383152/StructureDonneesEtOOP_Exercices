using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Synthese_2383152
{
    internal class Observateur : Utilisateur
    {
        private string IdObservateur {  get; set; }

        public Observateur (string id)
        {
            IdObservateur = id;
        }

        public override void AfficherInfo()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Profil Observateur: ");
            Console.WriteLine();
            Console.WriteLine("        Numero d'idendification: " + IdObservateur);
            Console.WriteLine("        Nom: " + Prenom + Nom);
            Console.WriteLine("        Date de naissance: " + DateNaissance);
            Console.WriteLine();
        }

    }
}
