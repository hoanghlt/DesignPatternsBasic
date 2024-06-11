using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Sword : IWeapon
    {
        private readonly IEnchantment _enchantment;
        public Sword(IEnchantment enchantment) 
        {
            _enchantment = enchantment;        
        }

        public void Weild()
        {
            Console.WriteLine("The sword is wielded.");
            _enchantment.OnActivate();
        }        

        public void Swing()
        {
            Console.WriteLine("The sword is swinged.");
            _enchantment.Apply();
        }

        public void UnWeild()
        {
            Console.WriteLine("The sword is unwielded.");
            _enchantment.OnDeactivate();
        }

        public IEnchantment GetEnchantment()
        {
            return _enchantment;
        }
    }
}
