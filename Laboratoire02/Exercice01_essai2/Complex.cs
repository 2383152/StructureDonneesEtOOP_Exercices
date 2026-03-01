using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01_essai2
{
    internal class Complex
    {
        /*Ma facons de faire get set n'est pas bonne:
         *      Ce sont des propriétés auto-implémentés
         *      le compilateur crée automatiquement un attribut privé caché
         *      la lecture et écriture sont publiques
         */

        /*
        public int nombreReel { get; set; }
        public int nombreImaginaire { get; set; }
        */

        /*Voici la bonne facons pour cette exercice:
         *      C'est la méthode plus ancienne, mais c'est ce qui est utilisé dans le corrigé de la prof
         */
        double nbReel, nbImaginaire;

        public double GetA() { return nbReel; }
        public double GetB() { return nbImaginaire; }

        public void SetA(double value) { nbReel = value; }
        public void SetB(double value) { nbImaginaire = value; }





        //Constructeur
        public Complex(int nombreReel, int nombreImaginaire)
        {
            this.nbReel = nombreReel;
            this.nbImaginaire = nombreImaginaire;
        }

        public string AfficherValeur()
        {
            return $"({nbReel}, {nbImaginaire})";
        }

        public double GetMagnitude()
        {
            return Math.Sqrt((nbReel * nbReel) + (nbImaginaire * nbImaginaire));
        }

        //Ca c'est que la prof a afite, mais je comprends pas tant comment ca fonctionne
        public void Sum(Complex nombre)
        {
            nbReel += nombre.GetA();
            nbImaginaire += nombre.GetB();
        }
    }
}
