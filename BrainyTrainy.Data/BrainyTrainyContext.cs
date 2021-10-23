using BrainyTrainy.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BrainyTrainy.Data
{
    public class BrainyTrainyContext : DbContext
    {
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GameHistory> GameHistories { get; set; }
        public virtual DbSet<GameProgress> GameProgresses { get; set; }
        public virtual DbSet<PersonInfo> PersonInfos { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public BrainyTrainyContext(DbContextOptions<BrainyTrainyContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }
    }
}