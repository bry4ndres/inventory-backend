﻿using TransactionService.Domain.Entities;

namespace TransactionService.Application.Interfaces
{
    public interface ITransactionRepository
    {
        Task<IEnumerable<Transaction>> GetAllAsync();
        Task<Transaction?> GetByIdAsync(int id);
        Task AddAsync(Transaction transaction);
        Task UpdateAsync(Transaction transaction);
        Task DeleteAsync(Transaction transaction);
    }
}
