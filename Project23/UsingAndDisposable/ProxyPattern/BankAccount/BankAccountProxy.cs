using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.ProxyPattern.BankAccount
{
    public class BankAccountProxy : IBankAccount
    {
        private readonly RealBankAccount _realBankAccount;
        private bool _isAdmin;
        public BankAccountProxy(double balance, bool isAdmin)
        {
            _realBankAccount = new RealBankAccount(balance);
            _isAdmin = isAdmin;
        }
        public void ShowBalance()
        {
            if(_isAdmin)
            {
                _realBankAccount.ShowBalance();
            }else
            {
                Console.WriteLine("فقط مدیران می‌توانند موجودی حساب را ببینند!");
            }
        }
    }
}