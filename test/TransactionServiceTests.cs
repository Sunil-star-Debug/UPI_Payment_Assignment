using Moq;
using UPIPaymentSystem.Data;
using UPIPaymentSystem.Models;
using UPIPaymentSystem.Services;
using Xunit;
using System.Threading.Tasks;
using System;

public class TransactionServiceTests
{
    private readonly Mock<UPIDatabaseContext> _mockContext;
    private readonly TransactionService _transactionService;

    public TransactionServiceTests()
    {
        // Create a mock of the UPIDatabaseContext
        _mockContext = new Mock<UPIDatabaseContext>();

        // Initialize the TransactionService with the mocked context
        _transactionService = new TransactionService(_mockContext.Object);
    }

    [Fact]
    public async Task ProcessPayment_ShouldAddTransactionToDatabase()
    {
        // Arrange: Create a new transaction object
        var transaction = new Transaction
        {
            UpiId = "user@upi",         // UPI ID of the user
            Amount = 100.0m,           // Transaction amount
            Timestamp = DateTime.UtcNow, // Current timestamp
            Status = "Pending"          // Initial status
        };

        // Act: Call the ProcessPayment method
        await _transactionService.ProcessPayment(transaction);

        // Assert: Verify that the InsertOneAsync method was called once with any Transaction object
        _mockContext.Verify(c => c.Transactions.InsertOneAsync(It.IsAny<Transaction>(), null, default), Times.Once);
    }
}
