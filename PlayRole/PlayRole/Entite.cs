using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRole
{
    public abstract class Entite
    {
        protected string nom;
        protected bool estMort = false;
        protected int pdV;
        protected int dgtMin;
        protected int dgtMax;
        protected Random random = new Random();

        public Entite(string nom)
        {
            this.nom = nom;
        }

        public void Attaquer(Entite uneEntite)
        {
            int degats = random.Next(dgtMin, dgtMax);

            uneEntite.PerdrePointsDeVie(degats);
            Console.WriteLine(this.nom + "(" + this.pdV + ")" + " attaque : " + uneEntite.nom);
            Console.WriteLine(uneEntite.nom + " a perdu " + degats + " points de vie");
            
            
            if(uneEntite.estMort)
            {
                Console.WriteLine(uneEntite.nom + " est mort.");
            }
            else
            {
                Console.WriteLine("Il reste " + uneEntite.pdV + " points de vie à " + uneEntite.nom);
            }
        }

        protected void PerdrePointsDeVie(int degats)
        {
            this.pdV -= degats;
            if (this.pdV <= 0)
            {
                this.estMort = true;
            }
        }

        public bool EstMort()
        {
            return this.estMort;
        }
    }
}
