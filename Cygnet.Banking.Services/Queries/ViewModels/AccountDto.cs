namespace Cygnet.Banking.Services.Queries.ViewModels
{
    public class AccountDto
    {
        public int Id { get; set; }
        public long AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public int AccountType { get; set; }
        public string? AccountTypeName { get; set; }
        public int CustomerId { get; set; }
    }
}