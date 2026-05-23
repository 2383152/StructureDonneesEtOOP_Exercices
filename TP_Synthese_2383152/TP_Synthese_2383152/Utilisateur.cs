using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Synthese_2383152
{
    internal class Utilisateur
    {
        protected string numeroIdentification { get; set; }
        protected string Nom { get; set; }
        protected DateTime DateNaissance { get; set; }
        protected string Adresse { get; set; }



        public virtual void AfficherInfo() { }
        
    }
}
