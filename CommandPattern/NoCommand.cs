using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No Command Assigned");
        }

        public void Undo()
        {
            Execute();
        }
    }
}
