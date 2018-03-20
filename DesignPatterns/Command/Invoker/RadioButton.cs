using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Commands;

namespace Command.Invoker
{
    public class RadioButton
    {
        private ICommand _command;
        public RadioButton(ICommand command)
        {
            _command = command;
        }


        public void RadioButtonPressed()
        {
            _command.Execute();
        }
    }
}
