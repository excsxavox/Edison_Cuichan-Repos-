using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GestionItems.App.Queries;
using GestionItemsTest.App.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GestionItems.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : Controller
    {
        private readonly IMediator _mediator;

        public ItemController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("assign")]
        public async Task<ActionResult> AssignItem([FromBody] AssignItemCommand command)
        {
            if (command == null || string.IsNullOrEmpty(command.AssignedTo))
            {
                return BadRequest("ItemId y AssignedTo son requeridos.");
            }

            var result = await _mediator.Send(command);
            return result ? Ok() : BadRequest("Item no encontrado o ya completado.");
        }

        [HttpGet("pending")]
        public async Task<IActionResult> GetPendingItems()
        {
            var items = await _mediator.Send(new GetPendingItemsQuery());
            return Ok(items);
        }

    }
}