using Cygnet.Banking.Services.Queries.AccountQueries;
using FluentValidation;

namespace Cygnet.Banking.Services.Validations.AccountValidation
{
    public class GetAccountBalanceQueryValidator : AbstractValidator<GetAccountBalanceQuery>
    {
        #region Constructors

        public GetAccountBalanceQueryValidator()
        {
            RuleFor(p => p.CustomerId).NotNull().NotEmpty();
            RuleFor(p => p.AccountType).NotNull().NotEmpty();
        }

        #endregion Constructors
    }
}