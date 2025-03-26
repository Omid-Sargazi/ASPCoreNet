using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.ProxyPattern.BankAccount
{
    public class RealBankAccount : IBankAccount
    {
        private double _balance;
        public RealBankAccount(double balance)
        {
            _balance = balance;
        }
        public void ShowBalance()
        {
            Console.WriteLine($"موجودی حساب: {_balance} تومان");
        }
    }
}