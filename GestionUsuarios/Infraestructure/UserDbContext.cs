using GestionUsuarios.Domain;
using Microsoft.EntityFrameworkCore;

public class UserDbContext : DbContext
{ public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        // DbSet para la entidad Item
        public DbSet<User> Users { get; set; }

        // Puedes agregar más DbSets aquí para otras entidades si es necesario

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
}
