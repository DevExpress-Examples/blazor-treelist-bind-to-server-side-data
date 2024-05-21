using Microsoft.EntityFrameworkCore;
using TreeListOnDemand.Services;

namespace TreeListOnDemand.Data {
    public class CitiesContext : DbContext {
        public DbSet<Location> Locations { get; set; }
        public CitiesContext(DbContextOptions<CitiesContext> options) : base(options) { }
    }
}
