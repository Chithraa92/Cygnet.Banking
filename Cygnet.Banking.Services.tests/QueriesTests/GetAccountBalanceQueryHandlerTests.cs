using System.Threading;
using System.Threading.Tasks;
using Cygnet.Banking.Domain.Aggregates;
using Cygnet.Banking.Domain.IRepository;
using Cygnet.Banking.Services.Queries.AccountQueries;
using Cygnet.Banking.Services.Queries.ViewModels;
using Moq;
using Shouldly;
using Xunit;

namespace Cygnet.Banking.Services.tests.QueriesTests
{
    public class GetAccountBalanceQueryHandlerTests
    {
        [Fact]
        public async Task GetAccountBalanceQueryHandler_WithResult()
        {
            //Arrange

            var mapper = MockMapper.GetMapperInstance();
            var balance = new Account()
            {
                Id = 1,
                AccountNumber = 111111,
                Balance = 4990,
            };

            var mockRepo = new Mock<IBankingRepository>();
            mockRepo.Setup(repo => repo.GetAccountAsync(1,1))
                .ReturnsAsync(balance);
            var handler = new GetAccountBalanceQueryHandler(mockRepo.Object, mapper);

            //Act
            var result = await handler
                .Handle(new GetAccountBalanceQuery(1,1), CancellationToken.None);
           
            //Assertion
            result.ShouldBeOfType<AccountDto>();
            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
            Assert.Equal(4990, result.Balance);
        }
    }
}
