namespace Exercice01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Facons 1:");
            // comment moi je l'ai fait:

            Solide matiere1 = new Solide("solide");

            matiere1.AfficherEtat();           
             
            var matiere1Changement1 = matiere1.ChangerEtat(30);
            matiere1Changement1.AfficherEtat();

            var matiere1Changement2 = matiere1Changement1.ChangerEtat(100);
            matiere1Changement2.AfficherEtat();


            Console.WriteLine();
            Console.WriteLine("Facons 2 (plus efficace):");

            //comment ca serait plus efficace:
            EtatMatiere matiere2 = new Solide("solide"); //important de mettre new solide sinon ca marche pas vrm

            matiere2.AfficherEtat();

            matiere2 = matiere2.ChangerEtat(10);
            matiere2.AfficherEtat();

            matiere2 = matiere2.ChangerEtat(100);
            matiere2.AfficherEtat();

            matiere2 = matiere2.ChangerEtat(30);
            matiere2.AfficherEtat();

            matiere2 = matiere2.ChangerEtat(-20);
            matiere2.AfficherEtat();

 
        }
    }
}
