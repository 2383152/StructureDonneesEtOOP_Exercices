using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    internal interface IvehiculePhysique
    {

        //doit créer ses méthodes dans I pour que on puisse les utiliser après
        void Demarrer();
        void Arreter();
        void AfficherInfo();
        double CalculerEnergieCinetique(); //les méthodes ne sont pas défini donc on n'a pas beosin de mettre override
        double CalculerPuissance();
        double CalculerAcceleration(double force);
    }
}
