using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.SubComponents
{
    internal class LoginAuthentication
    {
        private string _loginName = "TestUserName";
        private string _password = "TestUserPassword";

        public bool LoginAccepted(string userName, string userPassword)
        {
            return _loginName == userName && _password == userPassword;
        }
    }
}
