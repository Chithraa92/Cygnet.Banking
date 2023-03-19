using Cygnet.Banking.Services.Queries.ViewModels;
using MediatR;

namespace Cygnet.Banking.Services.Queries.TransactionQueries;
public record GetTransactionHistoryQuery(int CustomerId, int AccountId) : IRequest<List<TransactionDto>>;
