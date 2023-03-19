using Cygnet.Banking.Services.Queries.ViewModels;
using MediatR;

namespace Cygnet.Banking.Services.Commands
{
    public record AddTransactionsCommand  : IRequest<TransactionDto>
    {
        public string? Narration { get; set; }
        public decimal Withdrawal { get; set; }
        public decimal Deposit { get; set; }
        public int AccountId { get; set; }
        public int CustomerId { get; set; }
        public int BeneficiaryId { get; set; }
        public short TransactionTypeId { get; set; }
    }
}