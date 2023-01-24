using ApiTdrKms.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ApiTdrKms.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //Agregar los modelos aqui
        public DbSet<Distancia> Distancia { get; set; }
    }
}
