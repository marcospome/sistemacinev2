using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using semana4.Models;

public class ApplicationDbContext : IdentityDbContext<Usuario, IdentityRole, string, IdentityUserClaim<string>, IdentityUserRole<string>, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Pelicula> Peliculas { get; set; }
    public DbSet<Genero> Generos { get; set; }
    public DbSet<Clasificacion> Clasificaciones { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Funcion> Funcion { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" });
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "User", NormalizedName = "USER" });

        modelBuilder.Entity<Funcion>()
            .HasOne(f => f.Pelicula)
            .WithMany() // Sin especificar propiedad de navegación en Pelicula
            .HasForeignKey(f => f.PeliculaId)
            .IsRequired();
    }
}
