using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receiver;

namespace Command.Commands
{
    public class TurnRadioUpCommand : ICommand
    {
        private IRadio _radio;
        public TurnRadioUpCommand(IRadio radio)
        {
            _radio = radio;
        }

        public void Execute()
        {
            _radio.TurnRadioUp();
        }
    }
}
