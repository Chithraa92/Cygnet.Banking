using Cygnet.Banking.Services.Queries.ViewModels;
using MediatR;

namespace Cygnet.Banking.Services.Commands
{
    public record CreateAccountCommand : IRequest<AccountDto>
    {
        public int Id { get; set; }
        public long AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public int AccountType { get; set; }
        public string? AccountTypeName { get; set; }
        public int CustomerId { get; set; }
    }
}