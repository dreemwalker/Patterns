using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Models;
namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Blacksmith sm = new SwordMaster();
            Blacksmith bm = new BluntMaster();

            Weapon sword = sm.Forge();
            Weapon blunt = bm.Forge();
            Console.ReadLine();
        }
    }
}
