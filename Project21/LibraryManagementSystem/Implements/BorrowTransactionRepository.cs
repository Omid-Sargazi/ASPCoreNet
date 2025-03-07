using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Implements
{
    public class BorrowTransactionRepository : IBorrowTransactionRepository
    {
        public Task BorrowBookAsync(BorrowTransaction transaction)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BorrowTransaction>> GetAllTransactionsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BorrowTransaction>> GetOverdueTransactionsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BorrowTransaction> GetTransactionByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BorrowTransaction>> GetUserTransactionsAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task ReturnBookAsync(int transactionId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTransactionAsync(BorrowTransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}