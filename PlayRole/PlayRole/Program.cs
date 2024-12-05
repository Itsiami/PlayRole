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
            Monstre monstre = new Monstre("Lupus");
            bool victoire = true;
            bool suivant = false;

            // BOUCLE COMBAT TOUR PAR TOUR
            while (!monstre.EstMort())
            {
                // LE MONSTRE ATTAQUE
                Console.ForegroundColor = ConsoleColor.Red;
                monstre.Attaquer(monPerso);
                Console.WriteLine();
                Console.ReadKey(true);

                // SI PERSONNAGE MORT
                if (monPerso.EstMort())
                {
                    victoire = false;
                    break;
                }

                // LE PERSONNAGE ATTAQUE
                Console.ForegroundColor = ConsoleColor.Green;
                monPerso.Attaquer(monstre);
                Console.WriteLine();
                Console.ReadKey(true);
                }
            

            //SI VICTOIRE
            if (victoire)
            {
                monPerso.GagnerExp(5);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine(monPerso.Caracteristiques());

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();

                while (!suivant)
                {
                    Console.WriteLine("Salle suivante ? O/N");
                    string saisie = Console.ReadLine().ToUpper();
                    if (saisie == "O")
                    {
                        suivant = true;
                        Jouer(monPerso);
                    }
                    else if (saisie == "N")
                    {
                        Environment.Exit(0);
                    }
                }
            }
            // SI NON VICTOIRE
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("C'est perdu...");
                Console.ReadKey();
            }
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
                    Jouer(new Sorcier("Circé"));
                    break;

                case "4":
                    break;

            }
        }
    }
}