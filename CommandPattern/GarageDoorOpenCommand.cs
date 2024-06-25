using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class GarageDoorOpenCommand : ICommand
    {
        private readonly Garage _garage;

        public GarageDoorOpenCommand(Garage garage)
        {
            _garage = garage;
        }

        public void Execute()
        {
            _garage.Opened();
        }

        public void Undo()
        {
            _garage.Closed();
        }
    }
}
