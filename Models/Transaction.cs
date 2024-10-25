namespace UPIPaymentSystem.Models
{
    public class Transaction
    {
        public string Id { get; set; }           // Unique transaction ID
        public string? UpiId { get; set; }       // UPI ID of the user, now nullable
        public string? UserId { get; set; }      // User ID for filtering transactions, now nullable
        public decimal Amount { get; set; }      // Transaction amount
        public DateTime Timestamp { get; set; }  // Timestamp of the transaction
        public string? Status { get; set; }      // Status of the transaction (e.g., "Pending", "Completed"), now nullable
    }
}
