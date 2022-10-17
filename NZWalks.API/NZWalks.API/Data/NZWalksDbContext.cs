using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options): base(options)
        {

        }

        public DbSet<Region> Regions { get; set; } //If a table doesn't exist, please, create a table

        public DbSet<Walk> Walks { get; set; } //If a table doesn't exist, please, create a table

        public DbSet<WalkDifficulty> WalkDifficulty { get; set; } //If a table doesn't exist, please, create a table
    }
}
