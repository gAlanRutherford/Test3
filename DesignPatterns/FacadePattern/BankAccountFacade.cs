using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.SubComponents;

namespace FacadePattern
{
    public class BankAccountFacade
    {
        private BankAccount _bankAccount;
        private LoginAuthentication _loginAuthentication;
        private TwoFactorAuthentication _twoFactorAuthentication;

        private string _userName;
        private string _password;
        private int _securityCode;

        public BankAccountFacade(string userName, string password, int securityCode)
        {
            _userName = userName;
            _password = password;
            _securityCode = securityCode;
            _bankAccount = new BankAccount();
            _loginAuthentication = new LoginAuthentication();
            _twoFactorAuthentication = new TwoFactorAuthentication();
        }

        public double WithdrawCash(double cash)
        {
            if (_loginAuthentication.LoginAccepted(_userName, _password) &&
                _twoFactorAuthentication.SecurityCodeAccepted(_securityCode) &&
                _bankAccount.CashRequestWithLimit(cash))
            {
                return _bankAccount.WithdrawCash(cash);
                Console.WriteLine("Transaction Complete");
            }
            else
            {
                Console.WriteLine("Transaction Incomplete");
                return 0;
            }
        }
    }
}
