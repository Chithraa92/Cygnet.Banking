namespace Cygnet.Banking.Domain.Aggregates
{
    public class Beneficiary
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public long AccountNumber { get; set; }
        public string? EmailId { get; set; }
        public virtual AccountType AccountType { get; set; }
        public virtual Customer Customer { get; set; }

    }
}