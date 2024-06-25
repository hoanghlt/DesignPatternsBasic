using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class RemoteControl
    {
        private readonly ICommand[] _offCommand;
        private readonly ICommand[] _onCommand;
        private ICommand _undoCommand;

        public RemoteControl(int slots)
        {
            _offCommand = new ICommand[slots];
            _onCommand = new ICommand[slots];

            var none = new NoCommand();
            _undoCommand = none;
            for(int i = 0; i < slots; i++)
            {
                _offCommand[i] = none;
                _onCommand[i] = none;
            }
        }

        public OnOffStruct this[int slot]
        {
            set
            {
                _onCommand[slot] = value.On;
                _offCommand[slot] = value.Off;
            }
        }

        public void PushOn(int slot)
        {
            _onCommand[slot].Execute();
            _undoCommand = _offCommand[slot];
        }

        public void PushOff(int slot)
        {
            _offCommand[slot].Execute();
            _undoCommand = _onCommand[slot];
        }

        public void PushUndo()
        {
            _undoCommand.Execute();
        }
    }
}
