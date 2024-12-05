using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRole
{
    public class Guerrier : Personnage
    {
        public Guerrier(string nom) : base(nom)
        {
            pdV = 120;
            dgtMin = 10;
            dgtMax = 15;
        }
    }
}
