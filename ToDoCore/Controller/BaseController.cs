using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ToDoCore.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController : ControllerBase
    {
        protected readonly IMediator _mediator;
        protected readonly ILogger<BaseController> _logger;
        public BaseController(IMediator mediator, ILogger<BaseController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
    }
}
