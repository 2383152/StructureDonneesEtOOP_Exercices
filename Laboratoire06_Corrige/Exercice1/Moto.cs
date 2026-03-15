using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    internal class Moto : IvehiculePhysique
    {
        string modele;
        int cylindre;
        double masse;
        double vitesse, puissanceMoteur;

        public Moto(string modele, int cylindre, double masse, double vitesse, double puissanceMoteur)
        {
            this.modele = modele;
            this.cylindre = cylindre;
            this.masse = masse;
            this.vitesse = vitesse;
            this.puissanceMoteur = puissanceMoteur;
        }

        //Définition méthodes abstraitres
        public void Demarrer()
        {
            Console.WriteLine($"La moto {modele} démarre");
        }

        public void Arreter() => /* => remplace les accolades et le return */ Console.WriteLine($"La moto {modele} s'arrete");
        public void AfficherInfo() => Console.WriteLine($"La voiture {modele} démarre, Portes: {cylindre}, Masse: {masse}kg, Vitesse: {vitesse}m/s, Puissance: {puissanceMoteur} ");
        public double CalculerEnergieCinetique() => 0.5 * masse * Math.Pow(vitesse, 2);
        public double CalculerPuissance() => puissanceMoteur;
        public double CalculerAcceleration(double force) => force / masse;

    }
}
