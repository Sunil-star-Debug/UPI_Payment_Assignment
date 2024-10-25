using MongoDB.Driver;
using UPIPaymentSystem.Models;

namespace UPIPaymentSystem.Data
{
    public class UPIDatabaseContext
    {
        private readonly IMongoDatabase _database;

        public UPIDatabaseContext(IMongoClient client)
        {
            _database = client.GetDatabase("UPIPaymentDB"); // Use your actual database name
        }

        public IMongoCollection<User> Users => _database.GetCollection<User>("Users"); // Define Users collection

        public IMongoCollection<Transaction> Transactions => _database.GetCollection<Transaction>("Transactions"); // Existing Transactions collection
    }
}
