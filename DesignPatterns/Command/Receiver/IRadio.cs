using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receiver
{
    public interface IRadio
    {
        void TurnRadioUp();
        void TurnRadioDown();
    }
}
