using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Flies 500 Metres");
        }

        public void Quack()
        {
            Console.WriteLine("Quack Quack Quack");            
        }
    }
}
