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

        public override void AfficherInfo()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Profil Observateur: ");
            Console.WriteLine("        Numero d'idendification: ");
            Console.WriteLine("        Nom: ");
            Console.WriteLine("        Date de naissance");
            Console.WriteLine();
        }

    }
}
