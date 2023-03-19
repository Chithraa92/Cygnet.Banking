namespace Cygnet.Banking.Domain.Aggregates
{
    public class Ifsc
    {
        public short Id { get; set; }
        public string? Code { get; set; }
        public string? BranchName { get; set; }
        public string? BankName { get; set; }
    }
}