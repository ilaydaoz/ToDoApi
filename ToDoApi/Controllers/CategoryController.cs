﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoBusiness.Services.Queries.GetByFilter.Categories;
using ToDoCore.Controller;

namespace ToDoApi.Controllers
{
    public class CategoryController : BaseController
    {
        public CategoryController(IMediator mediator, ILogger<BaseController> logger) : base(mediator, logger)
        {
        }
        [HttpGet("filter")]
        public async Task<IActionResult> GetByFilterAsync([FromQuery] CategoryGetByFilterQueryRequestModel requestModel)
        {
            var response = await _mediator.Send(new CategoryGetByFilterQueryRequestModel
            {
                Name = requestModel.Name,
                Description = requestModel.Description,
                UrgencyLevel = requestModel.UrgencyLevel
            });
            return Ok(response);
        }

    }
}
