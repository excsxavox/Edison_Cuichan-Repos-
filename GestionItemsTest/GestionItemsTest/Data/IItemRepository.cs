using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionItemsTest.Domain;



namespace GestionItemsTest.Data
{
      public interface IItemRepository
    {
        Task<IEnumerable<Item>> GetPendingItemsAsync();
        Task<Item> GetItemByIdAsync(int id);
        Task SaveChangesAsync();
    }
}