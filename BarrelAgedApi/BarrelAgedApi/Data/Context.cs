using BarrelAgedApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BarrelAgedApi.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Beer> Beers { get; set; }
    }
}
