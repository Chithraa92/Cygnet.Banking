namespace Cygnet.Banking.Domain.Aggregates
{
    public class Transaction
    {
        public int Id { get; set; }
        public string? Narration { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Withdrawal { get; set; }
        public decimal Deposit { get; set; }
        public short TransactionTypeId { get; set; }
        public int BeneficiaryId { get; set; }
        public int AccountId { get; set; }
        public int CustomerId { get; set; }
        //public virtual TransactionType TransactionType { get; set; }
        //public virtual Beneficiary Beneficiary { get; set; }
        //public virtual Account Account { get; set; }
        //public virtual Customer Customer { get; set; }
    }
}