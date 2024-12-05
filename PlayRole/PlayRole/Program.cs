using System.ComponentModel.Design;
using System.Diagnostics;

namespace PlayRole
{
    class Program
    {

        static void Main(string[] args)
        {
            Menu();
        }

        static void Jouer(Personnage monPerso)
        {

        }

        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Play Role");
            Console.WriteLine();
            Console.WriteLine("Choisis ta classe : ");
            Console.WriteLine("1. Guerrier");
            Console.WriteLine("2. Archer");
            Console.WriteLine("3. Sorcier");
            Console.WriteLine("4. Quitter");
            Console.WriteLine();

            switch(Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Vous avez choisi Guerrier.");
                    Console.WriteLine();
                    Jouer(new Guerrier("Arès"));
                    break;

                case "2":
                    Console.WriteLine("Vous avez choisi Archer.");
                    Console.WriteLine();
                    Jouer(new Archer("Artémis"));
                    break;

                case "3":
                    Console.WriteLine("Vous avez choisi Sorcier.");
                    Console.WriteLine();
                    Jouer(new Sorcier("Hades"));
                    break;

                case "4":
                    break;

            }
        }
    }
}