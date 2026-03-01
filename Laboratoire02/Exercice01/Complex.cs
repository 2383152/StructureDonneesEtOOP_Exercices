using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    internal class Complex
    {

        //Ma facons de faire get set n'est pas bonne, mais jsp pk

        /*
        public int nombreReel { get; set; }
        public int nombreImaginaire { get; set; }
        */

        //Voici la bonne facons pour cette exercice:
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

        public double Sum()
        {
            return 
        }
    }
}
