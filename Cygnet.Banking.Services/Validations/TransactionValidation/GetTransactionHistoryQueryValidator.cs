using Cygnet.Banking.Services.Queries.TransactionQueries;
using FluentValidation;

namespace Cygnet.Banking.Services.Validations.TransactionValidation
{
    public class GetTransactionHistoryQueryValidator : AbstractValidator<GetTransactionHistoryQuery>
    {
        #region Constructors

        public GetTransactionHistoryQueryValidator()
        {
            RuleFor(p => p.CustomerId).NotNull().NotEmpty();
            RuleFor(p => p.AccountId).NotNull().NotEmpty();
        }

        #endregion Constructors
    }
}