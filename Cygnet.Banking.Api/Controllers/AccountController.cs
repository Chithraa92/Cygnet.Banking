using Cygnet.Banking.Services.Commands;
using Cygnet.Banking.Services.Helpers;
using Cygnet.Banking.Services.Queries.AccountQueries;
using Cygnet.Banking.Services.Queries.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cygnet.Banking.Api.Controllers
{
    [ApiController]
    [Route(ApiActionsV1.Account)]
    public class AccountController : ControllerBase
    {
        #region Properties

        private readonly ILogger<AccountController> _logger;
        private readonly IMediator _mediator;

        #endregion Properties

        #region Constructors

        public AccountController(ILogger<AccountController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        #endregion Constructors

        #region Methods

        [HttpGet(ApiActionsV1.GetAccountBalance, Name = nameof(ApiActionsV1.GetAccountBalance))]
        public async Task<ActionResult<AccountDto>> GetAccountBalance(
            [FromQuery] GetAccountBalanceQuery getAccountBalanceQuery)
        {
            return Ok(await _mediator.Send(getAccountBalanceQuery));
        }

        [HttpPost(ApiActionsV1.CreateAccount, Name = nameof(ApiActionsV1.CreateAccount))]
        public async Task<ActionResult<AccountDto>> CreateAccount(
            [FromBody] CreateAccountCommand createAccountCommand)
        {
            return CreatedAtAction(nameof(CreateAccount), await _mediator.Send(createAccountCommand));
        }

        [HttpPost(ApiActionsV1.CreateBeneficiary, Name = nameof(ApiActionsV1.CreateBeneficiary))]
        public async Task<ActionResult<CustomerDto>> CreateBeneficiary(
            [FromBody] CreateBeneficiaryCommand createBeneficiaryCommand)
        {
            return CreatedAtAction(nameof(CreateBeneficiary), await _mediator.Send(createBeneficiaryCommand));
        }

        [HttpPost(ApiActionsV1.CreateIfsc, Name = nameof(ApiActionsV1.CreateIfsc))]
        public async Task<ActionResult<IfscDto>> CreateIfsc(
            [FromBody] CreateIfscCommand createIfscCommand)
        {
            return CreatedAtAction(nameof(CreateIfsc), await _mediator.Send(createIfscCommand));
        }

        [HttpPut(ApiActionsV1.UpdateAccount, Name = nameof(ApiActionsV1.UpdateAccount))]
        public async Task<ActionResult<AccountDto>> UpdateWriteAssignment(
            [FromBody] UpdateAccountCommand updateAccountCommand)
        {
            return Ok(await _mediator.Send(updateAccountCommand));

            #endregion Methods
        }
    }
}