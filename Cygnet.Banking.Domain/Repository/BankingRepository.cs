using Cygnet.Banking.Domain.Aggregates;
using Cygnet.Banking.Domain.EntityFramework;
using Cygnet.Banking.Domain.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Cygnet.Banking.Domain.Repository
{
    public class BankingRepository : IBankingRepository
    {
        #region Properties

        private readonly BankingContext _context;
        //public IUnitOfWork UnitOfWork => _context;

        #endregion Properties

        #region Constructors

        public BankingRepository(BankingContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        #endregion Constructors

        #region Methods

        public Account? AddAccount(Account account)
        {
            return _context.Account?.Add(account).Entity;
        }

        public async Task<Transaction?> AddTransaction(Transaction transaction)
        {
            var entity = _context.Transaction?.Add(transaction).Entity;
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<Account?> UpdateAccount(Account account)
        {
            var entity = _context.Account?.Update(account).Entity;
            await _context.SaveChangesAsync();

            return entity;
        }

        public Beneficiary? AddBeneficiary(Beneficiary beneficiary)
        {
            return _context.Beneficiary?.Add(beneficiary).Entity;
        }

        public Customer? AddCustomer(Customer customer)
        {
            return _context.Customer?.Add(customer).Entity;
        }

        public async Task<List<Transaction>> GetTransactionAsync(int customerId, int accountId)
        {
            return await _context.Transaction?.Where(x =>
                x.CustomerId == customerId && (x.AccountId == accountId)).ToListAsync();
        }

        public async Task<Account> GetAccountAsync(int customerId, int accountType)
        {
            return await _context.Account?.SingleOrDefaultAsync(x =>
                x.Customer.Id == customerId && (x.AccountType.Id == accountType));
        }

        public async Task<Account> GetAccountByIdAsync(int accountId)
        {
            return await _context.Account.SingleOrDefaultAsync(x =>
                x.Id == accountId);
        }

        #endregion Methods
    }
}
