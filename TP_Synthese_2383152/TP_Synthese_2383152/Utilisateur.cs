using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Synthese_2383152
{
    internal class Utilisateur
    {
        private string Nom {  get; set; }
        private string Prenom { get; set; }
        private DateTime DateNaissance { get; set; }
        private string Adresse { get; set; }

        public virtual void AfficherInfo() { }
        
    }
}
