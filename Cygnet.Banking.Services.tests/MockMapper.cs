using AutoMapper;
using Cygnet.Banking.Api.Configuration.MapperProfiles;

namespace Cygnet.Banking.Services.tests
{
    public static class MockMapper
    {
        public static IMapper GetMapperInstance()
        {
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new BankingProfile());
            });
            return mockMapper.CreateMapper();
        }
    }
}