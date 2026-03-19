using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    internal class Vehicule:CorpsMouvement
    {
        public string TypeVehicule {  get; set; }

        public Vehicule(double vitesse, double position, double temps, string typeVehicule):base(vitesse, position, temps)
        {
            TypeVehicule = typeVehicule;
        }

        public void AfficherInfo()
        {
            Console.WriteLine("TypeVehicule: " + TypeVehicule);
            AfficherInfoCorpsMouvement();
        }
    }
}
