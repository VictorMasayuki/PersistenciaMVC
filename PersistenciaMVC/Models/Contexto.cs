using Microsoft.EntityFrameworkCore;

namespace PersistenciaMVC.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions <Contexto> options):
            base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Reserva> Reservas { get; set; }

        public DbSet<Hotel> Hoteis { get; set; }
    }
}
