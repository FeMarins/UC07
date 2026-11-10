using Microsoft.EntityFrameworkCore;
using Pizzaria.API.Models;

namespace Pizzaria.API.Data
{
    public class PizzariaDbContext : DbContext
    {
        public PizzariaDbContext(DbContextOptions<PizzariaDbContext> options)
             : base(options)
        {
        }

      public DbSet <Cliente> Clientes { get; set; }

    }
}
