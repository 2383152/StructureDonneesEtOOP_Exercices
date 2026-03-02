using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    internal class Avion
    {
        //Propriétés toujours avec une lettre majuscule
        public int NumeroVol {  get; set; }
        public string Destination { get; set; }
        public DateTime HeureDepart {  get; set; }

        //Corrigé pour temps de retard
        public int TempsRetard { get; set; }
        
        public Avion(int numeroVol, string destination, DateTime heureDepart)
        {
            this.NumeroVol = numeroVol;
            this.Destination = destination;
            this.HeureDepart = heureDepart;

            //Corrigé
            TempsRetard = 0;
        }

        public bool EstEnRetard()
        {
            if (HeureDepart < DateTime.Now)
                return true;
            else 
                return false;
        }

        //Corrigé statue de retard
        public void VerfierStatutVol()
        {
            if (TempsRetard == 0)
            {
                Console.WriteLine($"Le vol {NumeroVol} est à l'heure");
            }
            else
            {
                Console.WriteLine($"Le vol {NumeroVol} est retardé de {TempsRetard} minutes");
            }
        }

        //Corrigé pour temps de retard
        // Méthode pour mettre a jour l'heure de départ
        public void RetarderVol(int minutes)
        {
            TempsRetard += minutes;
            HeureDepart = HeureDepart.AddMinutes(minutes); //srx je comprends pas tant pk ou comment ca fonctionne
        }

        public double CalculerTempsRetard()
        {
            if (HeureDepart < DateTime.Now)
            {
                var tempsRetard = DateTime.Now - HeureDepart;
                return tempsRetard.Minutes;
            }
            else
                return 0;
        }

        public void AfficherInfo()
        {
            Console.WriteLine("Numero vol: " + NumeroVol);
            Console.WriteLine("Destination: " + Destination);
            Console.WriteLine("Heure de départ: " + HeureDepart.Hour + "h");
        }

    }
}
