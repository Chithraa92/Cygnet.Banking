using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Cygnet.Banking.Domain.Aggregates;
using Cygnet.Banking.Domain.IRepository;
using Cygnet.Banking.Services.Queries.TransactionQueries;
using Cygnet.Banking.Services.Queries.ViewModels;
using Moq;
using Shouldly;
using Xunit;

namespace Cygnet.Banking.Services.tests.QueriesTests
{
    public class GetTransactionHistoryQueryHandlerTests
    {
        [Fact]
        public async Task GetTransactionHistoryQuery_WithResult()
        {
            //Arrange

            var mapper = MockMapper.GetMapperInstance();
            var transactionDetails = new List<Transaction>()
            {
                new Transaction()
                {
                    Id = 4,
                    Narration = "Rent Paid to Owner",
                    Withdrawal = 500,
                    TransactionDate = DateTime.Now,
                    AccountId = 1
                },
                new Transaction()
                {
                    Id = 5,
                    Narration = "Rent Paid to Owner",
                    Withdrawal = 100,
                    TransactionDate = DateTime.Now,
                    AccountId = 1
                }
            };

            var mockRepo = new Mock<IBankingRepository>();
            mockRepo.Setup(repo => repo.GetTransactionAsync(1, 1))
                .ReturnsAsync(transactionDetails);
            var handler = new GetTransactionHistoryQueryHandler(mockRepo.Object, mapper);

            //Act
            var result = await handler
                .Handle(new GetTransactionHistoryQuery(1, 1), CancellationToken.None);

            //Assertion
            result.ShouldBeOfType<List<TransactionDto>>();
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
        }
    }
}