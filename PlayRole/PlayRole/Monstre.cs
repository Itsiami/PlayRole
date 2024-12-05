using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRole
{
    public class Monstre : Entite
    {
        public Monstre(string nom) : base (nom)
        {
            this.nom = nom;
            pdV = 50;
            dgtMin = 5;
            dgtMax = 10;
        }
    }
}
