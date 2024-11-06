using System.Threading;
using System.Threading.Tasks;
using GestionUsuarios.Data;
using MediatR;

namespace GestionUsuarios.app.Commands
{
    public class AssignUserCommandHandler : IRequestHandler<AssignUserCommand, bool>
    {
        private readonly IUserRepository _userRepository;

        public AssignUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(AssignUserCommand request, CancellationToken cancellationToken)
        {
            // Lógica para asignar un usuario a un ítem
            return await _userRepository.AssignUserAsync(request.UserId, request.Item);
        }
    }
}
