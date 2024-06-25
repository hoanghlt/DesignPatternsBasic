using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Garage
    {
        private readonly string _name;

        public Garage(string name)
        {
            _name = name;
        }

        internal void Opened()
        {
            Console.WriteLine($"{_name} Garage Opened");
        }

        internal void Closed()
        {
            Console.WriteLine($"{_name} Garage Closed");
        }
    }
}
