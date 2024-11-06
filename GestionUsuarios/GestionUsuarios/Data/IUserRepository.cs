using System.Threading.Tasks;
using GestionUsuarios.Domain;

namespace GestionUsuarios.Data
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(int id);
        Task<bool> AssignUserAsync(int userId, string item);
        Task SaveChangesAsync();
    }
}
