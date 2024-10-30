using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MediatR;
using GestionUsuarios.Application.Queries;


namespace GestionUsuarios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var query = new GetUserQuery(id);
            var user = await _mediator.Send(query);
            return Ok(user);
        }
    }
}
