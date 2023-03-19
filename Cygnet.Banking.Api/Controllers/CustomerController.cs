//using Cygnet.Banking.Services.Commands;
//using Cygnet.Banking.Services.Helpers;
//using Cygnet.Banking.Services.Queries.ViewModels;
//using MediatR;
//using Microsoft.AspNetCore.Mvc;

//namespace Cygnet.Banking.Api.Controllers
//{
//    [Route(ApiActionsV1.Customer)]
//    [ApiController]
//    public class CustomerController : ControllerBase
//    {
//        #region Properties

//        private readonly ILogger<CustomerController> _logger;
//        private readonly IMediator _mediator;

//        #endregion Properties

//        #region Constructors

//        public CustomerController(ILogger<CustomerController> logger, IMediator mediator)
//        {
//            _logger = logger;
//            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
//        }

//        #endregion Constructors

//        #region Methods

//        [HttpPost(ApiActionsV1.CreateCustomer, Name = nameof(ApiActionsV1.CreateCustomer))]
//        public async Task<ActionResult<CustomerDto>> CreateCustomer(
//            [FromBody] CreateCustomerCommand createCustomerCommand)
//        {
//            return CreatedAtAction(nameof(CreateCustomer), await _mediator.Send(createCustomerCommand));
//        }

//        #endregion Methods
//    }
//}