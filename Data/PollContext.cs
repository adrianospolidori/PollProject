using Data.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Data
{
    public class PollContext : DbContext
    {
        public PollContext(DbContextOptions<PollContext> options)
            : base(options)
        {
        }

        public DbSet<Poll> Poll { get; set; }
        public DbSet<PollOption> PollOption { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PollConfiguration());
            modelBuilder.ApplyConfiguration(new PollOptionConfiguration());
        }
     }
}
