using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> dbContextOptions): base(dbContextOptions)
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Difficulties
            // Easy, Medium, Hard

            var difficulties = new List<Difficulty>()
            {
             new Difficulty()
             {
                Id = Guid.Parse("9d89d8f3-97eb-475c-a748-4d71ddf4f8e2"),
                Name = "Easy"
             },
                new Difficulty()
                {
                    Id = Guid.Parse("85aa789b-c009-45ba-8223-6451c8e0a7c2"),
                    Name = "Medium"
                },
                new Difficulty() {
                    Id = Guid.Parse("03205c8a-abaa-4fe0-a893-2f9469862c11"),
                    Name = "Hard"
                }
            };

            // Seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            // Seed data for Regions
            var regions = new List<Region>()
            {
                new Region()
                {
                    Id = Guid.Parse("77da999a-7b86-4179-bbac-ae12067c80f3"),
                    Code = "AKL",
                    Name = "Auckland",
                    RegionImageUrl = "https://example.com/images/auckland.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("797a8585-6359-48c8-8ab8-7b70121fa9c3"),
                    Code = "WLG",
                    Name = "Wellington",
                    RegionImageUrl = "https://example.com/images/wellington.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("75eb3527-f28f-4776-b1c2-7348cddc8ccd"),
                    Code = "CHC",
                    Name = "Christchurch",
                    RegionImageUrl = "https://example.com/images/christchurch.jpg"
                }
            };

            // Seed regions to the database
            modelBuilder.Entity<Region>().HasData(regions);
        }

    }
}
