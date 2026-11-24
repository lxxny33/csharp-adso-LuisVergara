
using Inventario.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Inventario.Datos;

public class InventarioDbContext : DbContext
{
    public DbSet<Producto> Productos { get; set; }

    public DbSet<Categoria> Categorias { get; set; }

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=inventario.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>()
            .HasKey(p => p.Codigo);

        modelBuilder.Entity<Producto>()
            .Property(p => p.Precio)
            .HasPrecision(18, 2);

        modelBuilder.Entity<Categoria>()
            .HasKey(c => c.Id);

        modelBuilder.Entity<Producto>()
            .HasOne(p => p.Categoria)
            .WithMany(c => c.Productos)
            .HasForeignKey(p => p.CategoriaId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
