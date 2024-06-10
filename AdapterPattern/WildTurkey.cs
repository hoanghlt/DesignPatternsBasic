using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("Flies 100 Metres");
        }

        public void Gooble()
        {
            Console.WriteLine("Gooble Gooble Gooble");
        }
    }
}
