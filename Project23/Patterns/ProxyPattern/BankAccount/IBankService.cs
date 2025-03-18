using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.ProxyPattern.BankAccount
{
    public interface IBankService
    {
         decimal GetBalance(string accountNumber);
        bool Deposit(string accountNumber, decimal amount);
        bool Withdraw(string accountNumber, decimal amount);
        bool Transfer(string fromAccount, string toAccount, decimal amount);
    }
}