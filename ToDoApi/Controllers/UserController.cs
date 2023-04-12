using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoCore.Controller;
using ToDoListBusiness.Services.Commands.Delete.Users;
using ToDoListBusiness.Services.Commands.Insert.Users;

namespace ToDoListApi.Controllers
{
    public class UserController : BaseController
    {
        public UserController(IMediator mediator, ILogger<BaseController> logger) : base(mediator, logger)
        {
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync([FromBody] UserInsertCommandRequestModel request) =>
            Ok(await _mediator.Send(request));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var requestModel = new UserDeleteCommandRequestModel { Id = id };
            var response = await _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}
