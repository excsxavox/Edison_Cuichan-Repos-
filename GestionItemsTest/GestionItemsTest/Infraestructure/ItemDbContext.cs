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

        // DbSet para la entidad Item
        public DbSet<Item> Items { get; set; }

        // Puedes agregar más DbSets aquí para otras entidades si es necesario

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración adicional de la entidad si es necesario
            modelBuilder.Entity<Item>()
                .Property(i => i.Relevance)
                .HasConversion<string>(); // Asegúrate de que Relevance se almacene como cadena

            // Aquí puedes agregar configuraciones para otras entidades
        }
    }
}