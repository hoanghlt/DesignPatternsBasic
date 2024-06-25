using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class MacroCommand : ICommand
    {
        private readonly ICommand[] _command;

        public MacroCommand(ICommand[] command)
        {
            _command = command;
        }

        public void Execute()
        {
            foreach (var command in _command)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in _command)
            {
                command.Undo();
            }
        }
    }
}
