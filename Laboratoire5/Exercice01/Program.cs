namespace Exercice01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EtatMatiere matiere1 = new Solide();
            matiere1.AfficherEtat();

            //simulation pour changer l'état
            matiere1 = matiere1.ChangerEtat(-10); //reste un solide
            matiere1.AfficherEtat();

            matiere1 = matiere1.ChangerEtat(10);//Devient un liquide
            matiere1.AfficherEtat();

            matiere1 = matiere1.ChangerEtat(150);//Devient un gaz
            matiere1.AfficherEtat();

            matiere1 = matiere1.ChangerEtat(50);//Redevient un liquide
            matiere1.AfficherEtat();

            matiere1 = matiere1.ChangerEtat(-5);//Redevient un solide
            matiere1.AfficherEtat();
        }
    }
}
