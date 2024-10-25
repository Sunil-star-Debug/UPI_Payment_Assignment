using Moq;
using UPIPaymentSystem.Data; // Ensure this matches your project structure
using UPIPaymentSystem.Models; // This should match your Models namespace
using UPIPaymentSystem.Services; // Ensure the namespace is correct
using Xunit;
using System.Threading.Tasks;

public class UserServiceTests
{
    private readonly Mock<UPIDatabaseContext> _mockContext;
    private readonly UserService _userService;

    public UserServiceTests()
    {
        _mockContext = new Mock<UPIDatabaseContext>();
        _userService = new UserService(_mockContext.Object);
    }

    [Fact]
    public async Task Register_ShouldAddUserToDatabase()
    {
        var user = new User { UpiId = "user@upi", Name = "John", Email = "john@example.com", PasswordHash = "hashedPassword" };

        await _userService.Register(user);

        _mockContext.Verify(c => c.Users.InsertOneAsync(It.IsAny<User>(), null, default), Times.Once);
    }
}
