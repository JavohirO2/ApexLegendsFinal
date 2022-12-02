using ApexLegendsFinal.Models.guns;
using global::ApexLegendsFinal.Models.charater;
using Microsoft.EntityFrameworkCore;

namespace ApexLegendsFinal.Models.map
{
        public class mapcontext
        {
            public DbSet<Maps> Maps { get; set; }
            public DbSet<maptype> MapTypes { get; set; }
            protected void OnModelCreating(ModelBuilder modelBuilder)
            {
                // base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<maptype>().HasData(
                    new maptype { MapTypeId = 1, Name = "Arenas" },
                    new maptype { MapTypeId = 2, Name = "Battle Royale" }
                    
                    );

                modelBuilder.Entity<Maps>().HasData(
                    new { MapId = 1, Name = "Kings Canyon", MapTypeId = 2 },
                    new { MapId = 2, Name = "World's Edge", MapTypeId = 2 },
                    new { MapId = 3, Name = "Olympus", MapTypeId = 2 },
                    new { MapId = 4, Name = "Storm Point", MapTypeId = 2 },
                    new { MapId = 5, Name = "Broken Moon", MapTypeId = 2 },

                    new { MapId = 6, Name = "Drop Off", MapTypeId = 1 },
                    new { MapId = 7, Name = "Habit 4", MapTypeId = 1 },
                    new { MapId = 8, Name = "Encore", MapTypeId = 1 },
                    new { MapId = 9, Name = "OverFlow", MapTypeId = 1 },
                    new { MapId = 10, Name = "Party Crasher", MapTypeId = 1 },
                    new { MapId = 11, Name = "Phase Runner", MapTypeId = 1 }

                );
            }
        }
}
