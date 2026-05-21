using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Synthese_2383152
{
    internal class Systeme
    {
        protected List<double> echantillon;

        public void ChargerDonnees()
        {

        }

        public void SauvegarderDonnees(string nomFichier)
        {
            using (StreamWriter fichier = new StreamWriter(nomFichier))
            {
                foreach (double donnees in echantillon)
                {
                    fichier.WriteLine(donnees);
                }

                Console.WriteLine("Fichier sauvegardé en mémoire.");
                Console.WriteLine();
            }
        }

        public void ConnexionUtilisateur(string id)
        {

        }
    }
}
