namespace Exercice02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee01 = new Employee("dave", 20.25, new DateTime(2000, 08, 02));
            Console.WriteLine(employee01.AfficherValeur());
        }
    }
}
