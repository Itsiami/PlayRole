using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRole
{
    public class Sorcier : Personnage
    {
        public Sorcier(string nom) : base(nom)
        {
            pdV = 90;
            dgtMin = 20;
            dgtMax = 25;
        }
    }
}
