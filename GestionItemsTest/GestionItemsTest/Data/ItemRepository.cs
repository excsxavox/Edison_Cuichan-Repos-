using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionItems.Infraestructure;
using GestionItemsTest.Domain;
using Microsoft.EntityFrameworkCore;

namespace GestionItemsTest.Data
{
    public class ItemRepository : IItemRepository
    {
        private readonly ItemDbContext _context; // Cambia DbContext por ItemsDbContext

        public ItemRepository(ItemDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Item>> GetPendingItemsAsync()
        {
            return await _context.Items
                .Where(i => !i.IsCompleted)
                .OrderBy(i => i.DueDate)
                .ThenBy(i => i.Relevance == "Alta" ? 0 : 1)
                .ToListAsync(); // Usa ToListAsync() para obtener los resultados
        }

        public async Task<Item> GetItemByIdAsync(int id)
        {
            return await _context.Items.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
