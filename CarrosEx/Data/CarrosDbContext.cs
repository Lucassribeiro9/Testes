using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarrosEx.Data
{
    public class CarrosDbContext : DbContext
    {
        public DbSet<Carro> Carros { get; set; }

        public CarrosDbContext(DbContextOptions<CarrosDbContext> options) : base(options)
        {
        }
    }
}