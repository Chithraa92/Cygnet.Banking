using Cygnet.Banking.Domain.IRepository;
using Cygnet.Banking.Services.Queries.ViewModels;
using MediatR;

namespace Cygnet.Banking.Services.Commands
{
    public class CreateAccountCommandHandler : IRequestHandler<CreateAccountCommand, AccountDto>
    {
        #region Properties

        private readonly IBankingRepository _bankRepository;

        #endregion Properties

        #region Constructors

        public CreateAccountCommandHandler(IBankingRepository bankRepository)
        {
            _bankRepository = _bankRepository ?? throw new ArgumentNullException(nameof(bankRepository));
        }

        #endregion Constructors

        #region Methods

        public async Task<AccountDto> Handle(CreateAccountCommand request,
            CancellationToken cancellationToken)
        {
            // code here
            return new AccountDto();
        }

        #endregion
    }
}
