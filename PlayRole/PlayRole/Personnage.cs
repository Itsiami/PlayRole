using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRole
{
    public abstract class Personnage : Entite
    {
        private int niveau;
        private int exp;

        public Personnage(string nom) : base(nom)
        {
            this.nom = nom;
            this.niveau = 1;
            this.exp = 0;
        }

        public void GagnerExp(int experience)
        {
            this.exp += experience;
            while(this.exp >= ExperienceRequise())
            {
                niveau++;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Bravo, vous avez atteint le niveau " + niveau + " !");
                pdV += 10;
                dgtMin += 5;
                dgtMax += 5;
            }
        }

        public double ExperienceRequise()
        {
            return Math.Round(4 * (Math.Pow(niveau, 3) / 5));
        }

        public string Caracteristiques()
        {
            return this.nom + "\n" +
                "Point de vie : " + this.pdV + "\n" +
                "Niveau : " + this.niveau + "\n" +
                "Points d'expérience : " + this.exp + "/" + this.ExperienceRequise() + "\n" +
                "Dégats : [" + this.dgtMin + ";" + this.dgtMax + "]";
        }
    }
}
