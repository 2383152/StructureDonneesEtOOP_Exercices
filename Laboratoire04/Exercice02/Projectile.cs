using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    internal class Projectile : CorpsMouvement
    {
        public double Acceleration {  get; set; }

        public Projectile(double vitesse, double position, double temps, double acceleration) : base(vitesse, position, temps)
        {
            Acceleration = acceleration;
        }

        public void AvancerAcceleration(double tempsEntree)
        {

        }

        public void AfficherInfo()
        {
            Console.WriteLine("Acceleration: " + Acceleration);
            AfficherInfoCorpsMouvement();
        }
    }
}
