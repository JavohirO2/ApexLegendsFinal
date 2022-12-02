using ApexLegendsFinal.Models.charater;
using ApexLegendsFinal.Models.guns;
using Microsoft.EntityFrameworkCore;
using Web_final.Models;

namespace ApexLegendsFinal.Models.rank
{
    public class rankcontext
    {
        public DbSet<Rank> rank { get; set; }
        public DbSet<ranktype> userlevel { get; set; }
             protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ranktype>().HasData(
                new ranktype { UserId = 1, Name = "Sam" },
                new ranktype { UserId = 2, Name = "Jahior" },
                new ranktype { UserId = 3, Name = "Chelsea" }
                );
            modelBuilder.Entity<Apex_weapons>().HasData(
                new { RankTypeId = 1, Name = "Rookie", UserId = 1 },
                new { RankTypeId = 2, Name = "Gold", UserId = 2 },
                new { RankTypeId = 3, Name = "Predator", UserId = 3 }
            );
        }
     }
}
