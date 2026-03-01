namespace Exercice02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateEmbauche1 = new DateTime(2006, 05, 25);
            Employee employe1 = new Employee("Paulette", 100000, dateEmbauche1);

            employe1.AfficherInfo();
        }
    }
}
