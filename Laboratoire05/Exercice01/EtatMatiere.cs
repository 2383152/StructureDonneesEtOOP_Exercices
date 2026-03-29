using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    internal class EtatMatiere
    {
        string etat;
        
        public EtatMatiere(string etat)
        {
            this.etat = etat;
        }

        //Ici on créer un genre de template de méthode
        public virtual EtatMatiere /* ca a l'aire qu'il faut que ca return l'objet que la classe est */ ChangerEtat(double temperature)
        {
            //c'est qu'il faut faire:
            return this;

            /* Ca c'est ce que j'ai fait, mais ca a l'aire que c pas ca
             
            if (temperature <= 0)
                return "Solide";
            else if (temperature >= 100)
                return "Gazeux";
            else
                return "Liquide";

            */
        }

        public void AfficherEtat()
        {
            Console.WriteLine("L'état actuel: " + etat);
        }
    }
}
