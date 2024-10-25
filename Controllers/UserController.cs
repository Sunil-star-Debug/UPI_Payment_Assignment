using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UPIPaymentSystem.Models;
using UPIPaymentSystem.Services; // Ensure this is included

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    // Endpoint to get all users
    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await _userService.GetAllUsers();
        return Ok(users);
    }

    // Endpoint to get user by ID
    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById(string id)
    {
        var user = await _userService.GetUserById(id);
        if (user == null)
            return NotFound();
        return Ok(user);
    }
}
