namespace Exercice6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ville ville1 = new Ville("Quito");
            Pays pays = new Pays("Équateur", ville1);
            pays.AfficherInfo();

            Ville v1 = new Ville("Montréal", 45.30, -73.33, 2000000);
            Ville v2 = new Ville("Toronto");
            CoordGeo coordV3 = new CoordGeo("Vancouver");
            Ville v3 = new Ville("Vancouver", coordV3, 1000000);
            Pays p1 = new Pays("Canada", "Ottawa", v1, v2, v3);

        }
    }
}
