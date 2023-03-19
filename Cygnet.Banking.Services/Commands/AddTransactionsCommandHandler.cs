using AutoMapper;
using Cygnet.Banking.Domain.Aggregates;
using Cygnet.Banking.Domain.IRepository;
using Cygnet.Banking.Services.Queries.ViewModels;
using MediatR;

namespace Cygnet.Banking.Services.Commands
{
   
    public class AddTransactionsCommandHandler : IRequestHandler<AddTransactionsCommand, TransactionDto>
    {
        #region Properties

        private readonly IBankingRepository _bankingRepository;
        private readonly IMapper _mapper;

        #endregion Properties

        #region Constructor

        public AddTransactionsCommandHandler(IBankingRepository bankingRepository, IMapper mapper)
        {
            _bankingRepository = bankingRepository ?? throw new ArgumentNullException(nameof(bankingRepository));
            _mapper = mapper;
        }

        #endregion Constructor

        public async Task<TransactionDto> Handle(AddTransactionsCommand request, CancellationToken cancellationToken)
        {
            var transactionData = new Transaction()
            {
               Narration = request.Narration,
               TransactionDate = DateTime.Now,
               Withdrawal = request.Withdrawal,
               Deposit = request.Deposit,
               TransactionTypeId = request.TransactionTypeId,
               AccountId = request.AccountId,
               BeneficiaryId = request.BeneficiaryId,
               CustomerId = request.CustomerId,
            };
            var entity = await _bankingRepository.AddTransaction(transactionData);

            if (entity != null)
            {
                var account = await _bankingRepository.GetAccountByIdAsync(request.AccountId);
                account.Balance = request.Withdrawal != 0 ? account.Balance - request.Withdrawal
                    : request.Deposit == 0 ? account.Balance
                    : account.Balance + request.Deposit;
                await _bankingRepository.UpdateAccount(account);
            }

            var transactionDto = _mapper.Map<TransactionDto>(entity);
            return transactionDto;
        }
    }
}