using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.ProxyPattern.BankAccount
{
    public class BankAccountService
    {
        private Dictionary<string, decimal> _accounts;

    public BankAccountService()
    {
        // Initialize with some sample accounts
        _accounts = new Dictionary<string, decimal>
        {
            { "12345", 1000.00m },
            { "67890", 2500.00m },
            { "54321", 150.00m }
        };
    }

    public decimal GetBalance(string accountNumber)
    {
        if (_accounts.ContainsKey(accountNumber))
        {
            return _accounts[accountNumber];
        }
        return -1; // Indicating account not found
    }

    public bool Deposit(string accountNumber, decimal amount)
    {
        if (_accounts.ContainsKey(accountNumber))
        {
            _accounts[accountNumber] += amount;
            return true;
        }
        return false;
    }

    public bool Withdraw(string accountNumber, decimal amount)
    {
        if (_accounts.ContainsKey(accountNumber))
        {
            // No validation if there are sufficient funds
            _accounts[accountNumber] -= amount;
            return true;
        }
        return false;
    }

    public bool Transfer(string fromAccount, string toAccount, decimal amount)
    {
        if (_accounts.ContainsKey(fromAccount) && _accounts.ContainsKey(toAccount))
        {
            // No validation if there are sufficient funds
            _accounts[fromAccount] -= amount;
            _accounts[toAccount] += amount;
            return true;
        }
        return false;
    }
    }
}