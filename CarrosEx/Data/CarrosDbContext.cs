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