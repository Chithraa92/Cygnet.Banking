namespace Cygnet.Banking.Services.Queries.ViewModels
{
    public record TransactionDto
    {
        public int Id { get; set; }
        public string? Narration { get; set; }
        public decimal Withdrawal { get; set; }
        public decimal Deposit { get; set; }
        public decimal ClosingBalance { get; set; }
        public DateTime TransactionDate { get; set; }
        public string? AccountId { get; set; }
        public string? AccountType { get; set; }
        public string? ReferenceNumber { get; set; }
    }
}