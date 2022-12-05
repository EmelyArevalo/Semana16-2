using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana16.Data
{
    public class Semana16_ontext : DbContext
    {
        public Semana16Context(DbContextOptions<Semana16Context> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Teather> Teather { get; set; }
    }
}
