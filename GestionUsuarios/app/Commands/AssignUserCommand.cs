using MediatR;

namespace GestionUsuarios.app.Commands
{
    public class AssignUserCommand : IRequest<bool>
    {
        public int UserId { get; set; }
        public string Item { get; set; }
    }
}
