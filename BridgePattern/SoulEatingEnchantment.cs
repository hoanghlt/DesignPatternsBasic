﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class SoulEatingEnchantment : IEnchantment
    {
        public void OnActivate()
        {
            Console.WriteLine("The item spreads bloodlust.");
        }

        public void Apply()
        {
            Console.WriteLine("The item eats the soul of enemies.");
        }

        public void OnDeactivate()
        {
            Console.WriteLine("Bloodlust slowly disappears.");
        }
    }
}
