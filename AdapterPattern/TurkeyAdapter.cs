using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class TurkeyAdapter : IDuck
    {
        private readonly ITurkey _turkey;
        public TurkeyAdapter(ITurkey turkey) 
        {
            _turkey = turkey;
        }
        public void Fly()
        {
            for (var i = 0; i < 5; i++)
            {
                _turkey.Fly();
                Console.WriteLine("Resting..");
            }
        }

        public void Quack()
        {
            _turkey.Gooble();
        }
    }
}
