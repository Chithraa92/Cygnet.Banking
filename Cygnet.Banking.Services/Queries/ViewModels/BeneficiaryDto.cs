namespace Cygnet.Banking.Services.Queries.ViewModels
{
    public record BeneficiaryDto
    {
        public string? Name { get; set; }
        public string? AccountNumber { get; set; }
        public string? IfscCode { get; set; }
        public string? AccountType { get; set; }
        public string? EmailId { get; set; }
    }
}