using System.Threading.Tasks;
using GestionUsuarios.Domain;
using Microsoft.EntityFrameworkCore;

namespace GestionUsuarios.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly YourDbContext _context;

        public UserRepository(YourDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<bool> AssignUserAsync(int userId, string item)
        {
            // Lógica para asignar un ítem a un usuario
            return true; // o false si algo falla
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
