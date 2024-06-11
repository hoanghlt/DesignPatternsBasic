using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public interface IWeapon
    {
        void Weild();
        void Swing();
        void UnWeild();
        IEnchantment GetEnchantment();
    }
}
