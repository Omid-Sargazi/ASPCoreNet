using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Interfaces
{
    public interface IBorrowTransactionRepository
    {
        Task<IEnumerable<BorrowTransaction>> GetAllTransactionsAsync();
        Task<BorrowTransaction> GetTransactionByIdAsync(int id);
        Task<IEnumerable<BorrowTransaction>> GetUserTransactionsAsync(int userId);
        Task<IEnumerable<BorrowTransaction>> GetOverdueTransactionsAsync();
        Task BorrowBookAsync(BorrowTransaction transaction);
        Task ReturnBookAsync(int transactionId);
        Task UpdateTransactionAsync(BorrowTransaction transaction);
    }
}