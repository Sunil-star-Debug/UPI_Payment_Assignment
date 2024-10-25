using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using UPIPaymentSystem.Data;
using UPIPaymentSystem.Models;

namespace UPIPaymentSystem.Services
{
    public class UserService
    {
        private readonly UPIDatabaseContext _context;

        public UserService(UPIDatabaseContext context)
        {
            _context = context;
        }

        // Method to fetch all users
        public async Task<List<User>> GetAllUsers()
        {
            return await _context.Users.Find(user => true).ToListAsync();
        }

        // Method to get user by ID
        public async Task<User> GetUserById(string id)
        {
            return await _context.Users.Find(user => user.Id == id).FirstOrDefaultAsync();
        }

        // New method to register a user
        public async Task Register(User user)
        {
            await _context.Users.InsertOneAsync(user);
        }
    }
}
