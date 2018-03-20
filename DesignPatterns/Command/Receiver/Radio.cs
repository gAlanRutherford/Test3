using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receiver
{
    public class Radio : IRadio
    {
        private int volume = 10;
        public void TurnRadioDown()
        {
            volume--;
            DisplayMesssage();
        }

        public void TurnRadioUp()
        {
            volume++;
            DisplayMesssage();
        }

        private void DisplayMesssage()
        {
            Console.WriteLine("volume is at: {0}", volume);
        }
    }
}
