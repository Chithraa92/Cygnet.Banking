using AutoMapper;
using Cygnet.Banking.Domain.IRepository;
using Cygnet.Banking.Services.Queries.ViewModels;
using MediatR;

namespace Cygnet.Banking.Services.Queries.TransactionQueries
{
    public class GetTransactionHistoryQueryHandler : IRequestHandler<GetTransactionHistoryQuery, List<TransactionDto>>
    {
        #region Properties

        private readonly IBankingRepository _bankingRepository;
        private readonly IMapper _mapper;

        #endregion Properties


        #region Constructor
        public GetTransactionHistoryQueryHandler(IBankingRepository bankingRepository, IMapper mapper)
        {
            _bankingRepository = bankingRepository ?? throw new ArgumentNullException(nameof(bankingRepository));
            _mapper = mapper;
        }

        #endregion Constructor

        public async Task<List<TransactionDto>> Handle(GetTransactionHistoryQuery request, CancellationToken cancellationToken)
        {
            var data = await _bankingRepository.GetTransactionAsync(request.CustomerId, request.AccountId);
            List<TransactionDto> transactionDetails = _mapper.Map<List<TransactionDto>>(data);
            return transactionDetails;
        }
    }
}