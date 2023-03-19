using Cygnet.Banking.Services.Queries.ViewModels;
using MediatR;

namespace Cygnet.Banking.Services.Queries.AccountQueries;

public record GetAccountBalanceQuery(int CustomerId, int AccountType) : IRequest<AccountDto>;