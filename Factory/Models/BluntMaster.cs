﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Models
{
    class BluntMaster: Blacksmith
    {
        public override Weapon Forge()
        {
            return new Mace();
        }
    }
}
