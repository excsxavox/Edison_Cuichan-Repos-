using System.Threading;
using System.Threading.Tasks;
using GestionUsuarios.Application.Queries;
using GestionUsuarios.Data;
using GestionUsuarios.Domain;
using MediatR;

namespace GestionItemsTest.app.Queries
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, User>
    {
        private readonly IUserRepository _userRepository;

        public GetUserQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository.GetUserByIdAsync(request.Id);
        }
    }
}
