using Cygnet.Banking.Services.Commands;
using FluentValidation;

namespace Cygnet.Banking.Services.Validations.AccountValidation
{
    public class AddTransactionsCommandValidator : AbstractValidator<AddTransactionsCommand>
    {
        #region Constructors

        public AddTransactionsCommandValidator()
        {
            RuleFor(p => p.CustomerId).NotNull().NotEmpty();
            RuleFor(p => p.AccountId).NotNull().NotEmpty();
            RuleFor(p => p.BeneficiaryId).NotNull().NotEmpty();
            RuleFor(p => p.TransactionTypeId).NotNull().NotEmpty();
            RuleFor(p => p.Narration).NotNull().NotEmpty();
        }

        #endregion Constructors
    }
}