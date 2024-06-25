using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class GarageDoorCloseCommand : ICommand
    {
        private readonly Garage _garage;

        public GarageDoorCloseCommand(Garage garage)
        {
            _garage = garage;
        }

        public void Execute()
        {
            _garage.Closed();
        }

        public void Undo()
        {
            _garage.Closed();
        }
    }
}
