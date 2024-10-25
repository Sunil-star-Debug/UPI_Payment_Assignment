using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using UPIPaymentSystem.Data;
using UPIPaymentSystem.Models;

namespace UPIPaymentSystem.Services
{
    public class TransactionService
    {
        private readonly UPIDatabaseContext _context;

        public TransactionService(UPIDatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<Transaction>> GetTransactionHistory(string userId = null, string upiId = null)
        {
            var filter = Builders<Transaction>.Filter.Empty;

            if (!string.IsNullOrEmpty(userId))
                filter &= Builders<Transaction>.Filter.Eq(t => t.UserId, userId);

            if (!string.IsNullOrEmpty(upiId))
                filter &= Builders<Transaction>.Filter.Eq(t => t.UpiId, upiId);

            return await _context.Transactions.Find(filter).ToListAsync();
        }

        public async Task<Transaction> ProcessPayment(Transaction transaction)
        {
            await _context.Transactions.InsertOneAsync(transaction);
            return transaction;
        }

        // New method to get a transaction by its ID
        public async Task<Transaction> GetTransactionById(string id)
        {
            return await _context.Transactions.Find(t => t.Id == id).FirstOrDefaultAsync();
        }
    }
}
