using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receiver;

namespace Command.Commands
{
    public class TurnRadioDownCommand : ICommand
    {
        private IRadio _radio;
        public TurnRadioDownCommand(IRadio radio)
        {
            _radio = radio;
        }

        public void Execute()
        {
            _radio.TurnRadioDown();
        }
    }
}
