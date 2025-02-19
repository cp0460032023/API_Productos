using Microsoft.EntityFrameworkCore;
using API_Productos.Entity;

namespace API_Productos.Datos
{
    // Clase que representa el contexto de base de datos
    public class ApplicationDbContext : DbContext
    {
        // Constructor que recibe opciones de configuración
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Define el conjunto de datos para la entidad Productos
        public DbSet<Productos> Productos { get; set; }

        // Configuración adicional del modelo de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Llama al método base para garantizar configuraciones heredadas
            base.OnModelCreating(modelBuilder);

            // Configura la propiedad Id para que se genere automáticamente
            modelBuilder.Entity<Productos>().Property(product => product.Id).ValueGeneratedOnAdd();

            // Configura el campo Nombre como único en la base de datos
            modelBuilder.Entity<Productos>().HasIndex(product => product.Nombre).IsUnique();
        }
    }
}

