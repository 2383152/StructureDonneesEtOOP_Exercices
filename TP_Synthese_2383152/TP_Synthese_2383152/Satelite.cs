using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Synthese_2383152
{
    internal class Satelite : ObjetCeleste
    {
        Systeme systeme = new Systeme();

        public Satelite(string numReference)
        {
            systeme.ChargerDonnees("ObjetMission.csv");

            string[,] donneesObservateur = systeme.tableau;

            for (int i = 0; i < donneesObservateur.GetLength(0); i++)
            {
                for (int j = 0; j < donneesObservateur.GetLength(1); j++)
                {
                    if (donneesObservateur[i, 3] == numReference)
                    {
                        MatriculeScientifique = donneesObservateur[i, 0];
                        NumReferenceMission = donneesObservateur[i, 1];
                        _Type = donneesObservateur[i, 2];

                        break;
                    }
                }
            }
        }

        public override void CalculerForceGravitationnelle()
        {

        }

        public override void CalculerVitesseOrbitale()
        {

        }
    }
