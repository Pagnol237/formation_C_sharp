using System;
namespace formation_C_sharp
{
    class Program
    {
        static void Main(string[] arrgs)
        {
            /* exercice 1 : Demander à l’utilisateur son prénom et son âge, puis afficher :*/

            Console.WriteLine("bonjour quel est votre nom ?");
            string nom = Console.ReadLine();
            Console.WriteLine("quel est votre age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bonjour " + nom + " tu as " + age + " ans.");

            /* exercice 2: Demander à l’utilisateur de saisir la largeur et la hauteur d’un rectangle, puis afficher sa surface.
            (surface = largeur × hauteur)*/

            Console.WriteLine("saisir la longeur de votre figure");
            int longeur = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("saisir la largeur de votre figure :");
            int largeur = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("solution (calcule de la surface)\n************************\n\n S = L*l\n A.N:" + longeur + "+" + largeur + "=" + longeur * largeur);
    }
  }
}