using BoatRegistration.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace BoatRegistration.Data
{
    public class BaseContext : DbContext
    {
        public DbSet<Boat> Boats { get; set; }

        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
    }
}
