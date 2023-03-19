using Cygnet.Banking.Domain.Aggregates;

namespace Cygnet.Banking.Domain.IRepository
{
    public interface IBankingRepository
    {
        Account? AddAccount(Account account);

        Task<Account?> UpdateAccount(Account account);

        Task<Account> GetAccountByIdAsync(int accountId);

        Task<Transaction?> AddTransaction(Transaction transaction);

        Beneficiary? AddBeneficiary(Beneficiary beneficiary);

        Customer? AddCustomer(Customer customer);

        Task<List<Transaction>> GetTransactionAsync(int customerId, int accountId);

        Task<Account> GetAccountAsync(int customerId, int accountType);

    }
}