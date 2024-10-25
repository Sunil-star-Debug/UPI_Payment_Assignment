using Microsoft.AspNetCore.Mvc;
using UPIPaymentSystem.Models;  // Ensure this line is included
using UPIPaymentSystem.Services;
using System.Threading.Tasks;

[ApiController]
[Route("api/upi")]
public class UPIController : ControllerBase
{
    private readonly TransactionService _transactionService;

    public UPIController(TransactionService transactionService)
    {
        _transactionService = transactionService;
    }

    [HttpPost("pay")]
    public async Task<IActionResult> ProcessPayment(Transaction transaction)
    {
        var result = await _transactionService.ProcessPayment(transaction);
        return Ok(result);
    }

    [HttpGet("transaction/{id}")]
    public async Task<IActionResult> GetTransactionDetails(string id)
    {
        var transaction = await _transactionService.GetTransactionById(id);
        if (transaction == null)
            return NotFound();
        return Ok(transaction);
    }

    [HttpGet("transactions/{userId}")]
    public async Task<IActionResult> GetTransactionHistory(string userId)
    {
        var transactions = await _transactionService.GetTransactionHistory(userId);
        return Ok(transactions);
    }
}
