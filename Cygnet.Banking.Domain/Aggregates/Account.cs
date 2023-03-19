namespace Cygnet.Banking.Domain.Aggregates
{
    public class Account
    {
        public int Id { get; set; }
        public long AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public virtual AccountType AccountType { get; set; }
        public virtual Customer Customer { get; set; }
    }
}