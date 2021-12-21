using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAndTravel.Models
{
    public class ContextClass : DbContext
    {

        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=localhost;Database=CodeAndTravel;Integrated Security=True");
        }
    }
}
