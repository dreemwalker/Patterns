using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Models
{
    class Sword: Weapon
    {
        public Sword()
        {
            Console.WriteLine("new sword forged");
        }
    }
}
