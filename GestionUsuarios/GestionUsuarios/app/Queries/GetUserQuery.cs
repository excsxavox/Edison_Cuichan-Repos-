using GestionUsuarios.Domain;
using MediatR;

namespace GestionUsuarios.Application.Queries
{
    public class GetUserQuery : IRequest<User>
    {
        public int Id { get; set; }

        public GetUserQuery(int id)
        {
            Id = id;
        }
    }
}
