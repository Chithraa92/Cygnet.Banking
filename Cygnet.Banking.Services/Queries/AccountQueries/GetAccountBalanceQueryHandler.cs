using AutoMapper;
using Cygnet.Banking.Domain.IRepository;
using Cygnet.Banking.Services.Queries.ViewModels;
using MediatR;

namespace Cygnet.Banking.Services.Queries.AccountQueries
{
    public class GetAccountBalanceQueryHandler : IRequestHandler<GetAccountBalanceQuery, AccountDto>
    {
        #region Properties

        private readonly IBankingRepository _bankingRepository;
        private readonly IMapper _mapper;

        #endregion Properties


        #region Constructor
        public GetAccountBalanceQueryHandler(IBankingRepository bankingRepository, IMapper mapper)
        {
            _bankingRepository = bankingRepository ?? throw new ArgumentNullException(nameof(bankingRepository));
            _mapper = mapper;
        }

        #endregion Constructor

        public async Task<AccountDto> Handle(GetAccountBalanceQuery request, CancellationToken cancellationToken)
        {
            var data = await _bankingRepository.GetAccountAsync(request.CustomerId, request.AccountType);
            AccountDto accountDetails = _mapper.Map<AccountDto>(data);
            return accountDetails;
        }
    }
}
