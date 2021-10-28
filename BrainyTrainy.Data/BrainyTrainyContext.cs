using BrainyTrainy.Domain.Entities;
using BrainyTrainy.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

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

            // Seed database with all Colors
            foreach (GameType gameType in Enum.GetValues(typeof(GameType)).Cast<GameType>())
            {
                Game game = new Game
                {
                    Id = gameType,
                    Name = gameType.ToString(),
                };

                builder.Entity<Game>().HasData(game);
            }
        }
    }
}