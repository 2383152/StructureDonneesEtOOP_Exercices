using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    internal class Voiture : IvehiculePhysique
    {
        string marque;
        int nombrePorte;
        double masse;
        double vitesse, puissanceMoteur;

        public Voiture(string marque, int nombrePorte, double masse, double vitesse, double puissanceMoteur)
        {
            this.marque = marque;
            this.nombrePorte = nombrePorte;
            this.masse = masse;
            this.vitesse = vitesse;
            this.puissanceMoteur = puissanceMoteur;
        }

        //Définition méthodes abstraitres
        public void Demarrer()
        {
            Console.WriteLine($"La voiture {marque} démarre");
        }

        public void Arreter() => /* => remplace les accolades et le return */ Console.WriteLine($"La voiture {marque} s'arrete");
        public void AfficherInfo() => Console.WriteLine($"La voiture {marque} démarre, Portes: {nombrePorte}, Masse: {masse}kg, Vitesse: {vitesse}m/s, Puissance: {puissanceMoteur} ");
        public double CalculerEnergieCinetique() => 0.5 * masse * Math.Pow(vitesse, 2);
        public double CalculerPuissance() => puissanceMoteur;
        public double CalculerAcceleration(double force) => force / masse;


    }
}
