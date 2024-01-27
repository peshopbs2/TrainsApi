using Microsoft.EntityFrameworkCore;
using TrainsApi.Data.Entities;

namespace TrainsApi.Data.Seeders
{
    public static class DataSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            SeedLocations(modelBuilder);
        }

        public static void SeedLocations(this ModelBuilder modelBuilder)
        {
            List<Location> locations =
                new List<string>()
            {
                "Burgas", "Aytos", "Karnobat", "Straldzha", "Yambol", "Nova Zagora", "Stara Zagora", "Chirpan", "Plovdiv", "Pazardjik", "Septemvri", "Belovo", "Kostenec", "Ihtiman", "Sofia"
            }
                .Select((item, index) => new Location() {Id = index + 1, Name = item })
                .ToList();

            modelBuilder.Entity<Location>()
                .HasData(locations);
        }
    }
}
