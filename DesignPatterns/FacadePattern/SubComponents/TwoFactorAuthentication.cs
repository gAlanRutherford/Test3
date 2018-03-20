using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.SubComponents
{
    internal class TwoFactorAuthentication
    {
        private int _securityCode = 123456;

        public bool SecurityCodeAccepted(int securityCode)
        {
            return _securityCode == securityCode;
        }
    }
}
