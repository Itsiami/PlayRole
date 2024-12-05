using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRole
{
    public class Archer : Personnage
    {
        public Archer(string nom) : base(nom)
        {
            pdV = 100;
            dgtMin = 15;
            dgtMax = 20;
        }
    }
}
