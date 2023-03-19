using System.Reflection;
using Autofac;
using Cygnet.Banking.Services.Behavior;
using Cygnet.Banking.Services.Queries.AccountQueries;
using Cygnet.Banking.Services.Validations.AccountValidation;
using FluentValidation;
using MediatR;
using Module = Autofac.Module;

namespace Cygnet.Banking.Api.Configuration
{
    public class MediatorModule : Module
    {
        #region Methods

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(IMediator).GetTypeInfo().Assembly)
                .AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(typeof(GetAccountBalanceQueryHandler).GetTypeInfo().Assembly)
                .AsClosedTypesOf(typeof(IRequestHandler<,>));
            builder.RegisterAssemblyTypes(typeof(GetAccountBalanceQueryValidator).GetTypeInfo().Assembly)
                .Where(t => t.IsClosedTypeOf(typeof(IValidator<>)))
                .AsImplementedInterfaces();
            builder.RegisterGeneric(typeof(ValidatorBehavior<,>)).As(typeof(IPipelineBehavior<,>));
        }

        #endregion Methods
    }
}