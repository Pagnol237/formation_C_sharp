using System;
namespace formation_C_sharp
{
    class Program
    {
        static void Main(string[] arrgs)
        {
            /* exercice 1 : Demander à l’utilisateur son prénom et son âge, puis afficher :

            Console.WriteLine("bonjour quel est votre nom ?");
            string nom = Console.ReadLine();
            Console.WriteLine("quel est votre age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bonjour " + nom + " tu as " + age + " ans.");

             exercice 2: Demander à l’utilisateur de saisir la largeur et la hauteur d’un rectangle, puis afficher sa surface.
            (surface = largeur × hauteur)

            Console.WriteLine("saisir la longeur de votre figure");
            int longeur = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("saisir la largeur de votre figure :");
            int largeur = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("solution (calcule de la surface)\n************************\n\n S = L*l\n A.N:" + longeur + "+" + largeur + "=" + longeur * largeur);
            */
            /* exerice 1 calcule de la moyenne*/
            Console.WriteLine("saisir votre note de maths .../20");
            double note_maths = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("saisir votre note de d\'informatique .../20");
            double note_infos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("saisir votre note  d\'édu .../20");
            double note_edu = Convert.ToDouble(Console.ReadLine());

            double moyenne = (note_edu + note_infos + note_maths) / 3;

            string mention =(moyenne<10)?"ÉCHEC" : (moyenne > 10  && moyenne<12)? "PASSABLE": (moyenne >12 && moyenne<14)?" ASSEZ BIEN": (moyenne >14 && moyenne<16)?"BIEN":"TRÈS BIEN";

            Console.WriteLine("Résultat \n----------------------\n");
            Console.WriteLine($"maths :\t{note_maths}\ninfos :\t{note_infos}\nédu :\t{note_edu}\n*Moyenne :*\t{moyenne}\nMENTION : \t{mention}\n**********");


    }
  }
}