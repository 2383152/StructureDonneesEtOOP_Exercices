using System;

namespace Exercice04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avion vol1 = new Avion("AB123", "Paris", new DateTime(2026, 02, 04, 15, 30, 0));
            vol1.AfficherInformationVol();

            // Retard de vol de 20 minutes
            Console.WriteLine("--------------------");
            vol1.RetarderVol(20);
            // vérifier le statut du vol 
            vol1.VerfierStatutVol();
            Console.WriteLine("--------------------");
            vol1.AfficherInformationVol();
        }
    }
}
