using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice07;

namespace Laboratoire07
{
    internal class Ferme
    {
        int nbAnimaux;

        List<Animal> ListeAnimaux = new List<Animal>();

        //"create" = constructeur de la classe
        public Ferme(int nbAnimaux)
        {
            this.nbAnimaux = nbAnimaux;
        }

        public void ajouterAnimal(Animal animal)
        {
            ListeAnimaux.Add(animal); //il faut que je comprenne que le ajouter animal veut dire ajouter a une liste
        }

        public void ecouterAnimaux()
        {
            foreach(var animal in ListeAnimaux)
            {
                animal.PousserCri(); //ca aussi je pourrais le comprendre avec des context clues
            }
        }
    }
}
