using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoBusiness.Services.Commands.Insert.ToDoLists;
using ToDoCore.Controller;
using ToDoListBusiness.Services.Commands.Delete.ToDoLists;

namespace ToDoListApi.Controllers
{

    public class ToDoListController : BaseController
    {
        public ToDoListController(IMediator mediator, ILogger<BaseController> logger) : base(mediator, logger)
        {
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync([FromBody] ToDoListInsertCommandRequestModel request) => 
            Ok(await _mediator.Send(request));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var requestModel = new ToDoListDeleteCommandRequestModel { Id = id };
            var response = await _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}
