using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Synthese_2383152
{
    internal abstract class ObjetCeleste
    {
        protected string MatriculeScientifique { get; set; }
        protected string NumReferenceMission { get; set; }
        protected string _Type { get; set; }

        public void CalculerNombreMission()
        {

        }

        public abstract void CalculerForceGravitationnelle();

        public abstract void CalculerVitesseOrbitale();
    }
}
