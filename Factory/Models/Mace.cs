﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Models
{
    class Mace: Weapon
    {
        public Mace()
        {
            Console.WriteLine("new mace forged");
        }
    }
}
