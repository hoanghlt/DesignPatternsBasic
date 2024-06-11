using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Hammer : IWeapon
    {
        private readonly IEnchantment _enchantment;

        public Hammer(IEnchantment enchantment)
        {
            _enchantment = enchantment;
        }

        public void Weild()
        {
            Console.WriteLine("The hammer is wielded.");
            _enchantment.OnActivate();
        }

        public void Swing()
        {
            Console.WriteLine("The hammer is swinged.");
            _enchantment.Apply();
        }

        public void UnWeild()
        {
            Console.WriteLine("The hammer is unwielded.");
            _enchantment.OnDeactivate();
        }       

        public IEnchantment GetEnchantment()
        {
            return _enchantment;
        }
    }
}
