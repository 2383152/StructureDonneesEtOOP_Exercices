using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice04
{
    internal class Avion
    {
        //get = voir variable / set = modifier variable
        public string NumeroVol { get; set; }
        public string Destination { get; set; }
        public DateTime HeureDeDepart { get; set; }

        public int TempsRetard { get; private set; }

        public Avion(string NumeroVol, string Destination, DateTime HeureDeDepart)
        {
            this.NumeroVol = NumeroVol;
            this.Destination = Destination;
            this.HeureDeDepart = HeureDeDepart;
            TempsRetard = 0;
        }
        // Méthode pour afficher le statut du vol
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
        // Afficher l'information sur le vol
        public void AfficherInformationVol()
        {
            Console.WriteLine($"Numéro de vol: {NumeroVol} \nDestination du vol : {Destination} \nHeure du depart du vol : {HeureDeDepart} \nTemps de retard du vol : {TempsRetard}");
        }
        // Méthode pour mettre a jour l'heure de départ

        public void RetarderVol(int minutes)
        {
            TempsRetard += minutes;
            HeureDeDepart = HeureDeDepart.AddMinutes(minutes);
        }
    }
}
