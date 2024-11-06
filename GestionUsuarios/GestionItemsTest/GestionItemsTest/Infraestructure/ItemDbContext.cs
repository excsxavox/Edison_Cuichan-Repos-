using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionItemsTest.Domain;
using Microsoft.EntityFrameworkCore;

namespace GestionItems.Infraestructure
{
     public class ItemDbContext : DbContext
    {
        public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options)
        {
        }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración adicional de la entidad si es necesario
            modelBuilder.Entity<Item>()
                .Property(i => i.Relevance)
                .HasConversion<string>(); 
        }
    }
}