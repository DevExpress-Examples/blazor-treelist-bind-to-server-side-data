using Microsoft.EntityFrameworkCore;
using TreeListOnDemand.Data;

namespace TreeListOnDemand.Services {
    public class CitiesService {
        CitiesContext _context;
        public CitiesService(IDbContextFactory<CitiesContext> contextFactory) {
            _context = contextFactory.CreateDbContext();
        }
        public void SeedData() {
            _context.Database.EnsureCreated();
            if (_context.Locations.Any())
                return;
            var stream = File.OpenRead(@"cities.json");
            var cities = System.Text.Json.JsonSerializer.Deserialize<Location[]>(stream);
            if (cities == null)
                return;
            foreach (var city in cities) {
                city.ID++;
                city.ParentID++;
            }
            _context.Locations.AddRange(cities);
            _context.SaveChanges();
        }

        public async Task<Location[]?> GetCitiesAsync() {
            await _context.Locations.LoadAsync();
            return _context.Locations.Local.ToArray();
        }
    }
}
