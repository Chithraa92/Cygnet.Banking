using Cygnet.Banking.Services.Helpers;
using FluentValidation;
using MediatR;

namespace Cygnet.Banking.Services.Behavior
{
    public class ValidatorBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        #region Properties

        private readonly IValidator<TRequest>[] _validators;

        #endregion Properties

        #region Constructors

        public ValidatorBehavior(IValidator<TRequest>[] validators)
        {
            _validators = validators ?? throw new ArgumentNullException(nameof(validators));
        }

        #endregion Constructors

        #region Methods

        public async Task<TResponse> Handle(TRequest request,
            RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var typeName = request.GetGenericTypeName();
            var failures = _validators.Select(v => v.Validate(request))
                .SelectMany(result => result.Errors)
                .Where(error => error != null)
                .ToList();
            if (failures.Any())
                //throw new BankingValidationException(failures, typeName, HttpStatusCode.BadRequest);
                throw new FluentValidation.ValidationException(failures);
            return await next();
        }

        #endregion Methods
    }
}