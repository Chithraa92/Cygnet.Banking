using AutoMapper;
using Cygnet.Banking.Domain.Aggregates;
using Cygnet.Banking.Services.Queries.ViewModels;

namespace Cygnet.Banking.Api.Configuration.MapperProfiles
{
    public class BankingProfile : Profile
    {
        public BankingProfile()
        {
            CreateMap<Account, AccountDto>();
            CreateMap<Transaction, TransactionDto>();
        }
    }
}