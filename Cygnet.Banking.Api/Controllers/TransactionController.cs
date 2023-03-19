using Cygnet.Banking.Services.Commands;
using Cygnet.Banking.Services.Helpers;
using Cygnet.Banking.Services.Queries.TransactionQueries;
using Cygnet.Banking.Services.Queries.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cygnet.Banking.Api.Controllers
{
    [Route(ApiActionsV1.Transaction)]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        #region Properties
        
        private readonly ILogger<TransactionController> _logger;
        private readonly IMediator _mediator;

        #endregion Properties

        #region Constructors

        public TransactionController(ILogger<TransactionController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        #endregion Constructors

        #region Methods

        [HttpGet(ApiActionsV1.GetTransactionHistory, Name = nameof(ApiActionsV1.GetTransactionHistory))]
        public async Task<ActionResult<List<TransactionDto>>> GetTransactionHistory(
            [FromQuery] GetTransactionHistoryQuery getTransactionHistoryQuery)
        {
            return Ok(await _mediator.Send(getTransactionHistoryQuery));
        }

        [HttpPost(ApiActionsV1.AddTransactions, Name = nameof(ApiActionsV1.AddTransactions))]
        public async Task<ActionResult<TransactionDto>> AddTransactions(
            [FromBody] AddTransactionsCommand addTransactionsCommand)
        {
            return CreatedAtAction(nameof(AddTransactions), await _mediator.Send(addTransactionsCommand));
        }

        #endregion Methods
    }
}