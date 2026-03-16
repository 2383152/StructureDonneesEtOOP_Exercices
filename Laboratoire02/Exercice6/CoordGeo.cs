using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    internal class CoordGeo
    {
        public double Longitude {  get; set; }
        public double Latitude { get; set; }

        public CoordGeo() //si on ne connais pas la longitude et latitude, ca les initialise a 0
        {
            Longitude = 0;
            Latitude = 0;
        }

        public CoordGeo(double longitude, double latitude)
        {
            this.Longitude = longitude;
            this.Latitude = latitude;
        }

        public CoordGeo(string ville)
        {
            
            if (ville == "Greenwich")
            {
                Longitude = 0.11;
                Latitude = 0.11;
            }
            else if (ville == "St-Jérôme")
            {
                Longitude = 0.22;
                Latitude = 0.22;
            }
            else if (ville == "Sydney")
            {
                Longitude = 0.33;
                Latitude = 0.33;
            }
            else if (ville == "Ottawa")
            {
                Longitude = 0.44;
                Latitude = 0.44;
            }
            else if (ville == "Toronto")
            {
                Longitude = 0.55;
                Latitude = 0.55;
            }
            else if (ville == "Toronto")
            {
                Longitude = 0.66;
                Latitude = 0.66;
            }
            else if (ville == "Vancouver")
            {
                Longitude = 0.77;
                Latitude = 0.77;
            }
            else if (ville == "Quito")
            {
                Longitude = 0.88;
                Latitude = 0.88;
            }
            else
            {
                Longitude = 0.0;
                Latitude = 0.0;
            }
        }

        public void AfficherCoord()
        {
            Console.WriteLine("Longitude: " + Longitude);
            Console.WriteLine("Latitude: " + Latitude);
        }
    
    }
}
