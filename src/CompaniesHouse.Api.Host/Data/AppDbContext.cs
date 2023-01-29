using CompaniesHouse.Api.Host.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CompaniesHouse.Api.Host.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }

        public AppDbContext(DbContextOptions options) : base(options) { }
    }
}
