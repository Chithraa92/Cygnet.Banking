using System;
using System.Threading;
using System.Threading.Tasks;
using Cygnet.Banking.Domain.Aggregates;
using Cygnet.Banking.Domain.IRepository;
using Cygnet.Banking.Services.Commands;
using Moq;
using Xunit;

namespace Cygnet.Banking.Services.tests.CommandsTests
{
    public class AddTransactionsCommandHandlerTests
    {
        [Fact]
        public async Task AddTransactionsCommandHandler_WithResult()
        {
            //Arrange

            var mapper = MockMapper.GetMapperInstance();
            var transactionResponse = new Transaction()
            {
                Id = 1,
                Narration = "Rent Paid to Owner",
                Withdrawal = 500,
                TransactionDate = DateTime.Now,
                AccountId = 1,
                TransactionTypeId = 1,
                BeneficiaryId = 1,
                CustomerId = 1
            };

            var mockRepo = new Mock<IBankingRepository>();
            mockRepo
                .Setup(repo => repo.AddTransaction(It.IsAny<Transaction>()))
                .ReturnsAsync(transactionResponse);
            mockRepo
                .Setup(repo => repo.GetAccountByIdAsync(It.IsAny<int>()))
                .ReturnsAsync(new Account(){AccountNumber = 11111, Balance = 1000, Id = 1});
            mockRepo
                .Setup(repo => repo.UpdateAccount(It.IsAny<Account>()));

            var handler = new AddTransactionsCommandHandler(mockRepo.Object, mapper);

            //Act
            var result = await handler
                .Handle(new AddTransactionsCommand(), CancellationToken.None);

            //Assertion
            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
        }
    }
}
