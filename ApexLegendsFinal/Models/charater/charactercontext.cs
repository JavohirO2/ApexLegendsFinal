using ApexLegendsFinal.Models.guns;
using Microsoft.EntityFrameworkCore;

namespace ApexLegendsFinal.Models.charater
{
    public class charactercontext
    {
        public DbSet<characters> character{ get; set; }
        public DbSet<charactertype> CharacterType { get; set; }
        protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<charactertype>().HasData(
                new charactertype { charactertypeId = 1, Name = "Assault" },
                new charactertype { charactertypeId = 2, Name = "Recon" },
                new charactertype { charactertypeId = 3, Name = "Support" },
                new charactertype { charactertypeId = 4, Name = "Tank" }
                );

            modelBuilder.Entity<characters>().HasData(
                new { CharacterId = 1, Name = "Wraith", charactertypeId = 1 },
                new { CharacterId = 2, Name = "Bangalore", charactertypeId = 1 },
                new { CharacterId = 3, Name = "Mirge", charactertypeId = 1 },
                new { CharacterId = 4, Name = "Octane", charactertypeId = 1 },
                new { CharacterId = 5, Name = "Revenant", charactertypeId = 1 },
                new { CharacterId = 6, Name = "Horizon", charactertypeId = 1 },
                new { CharacterId = 7, Name = "Fuze", charactertypeId = 1 },
                new { CharacterId = 8, Name = "Ash", charactertypeId = 1 },              
                new { CharacterId = 9, Name = "Mad Maggie", charactertypeId = 1 },
               
                new { CharacterId = 10, Name = "Bloodhound", charactertypeId = 2 },
                new { CharacterId = 11, Name = "Pathfinder", charactertypeId = 2 },
                new { CharacterId = 12, Name = "Crypto", charactertypeId = 2 },
                new { CharacterId = 13, Name = "Valkyrie", charactertypeId = 2 },
                new { CharacterId = 14, Name = "Seer", charactertypeId = 2 },
                new { CharacterId = 15, Name = "Vantage", charactertypeId = 2 },
               
                new { CharacterId = 16, Name = "Gibraltar", charactertypeId = 3 },
                new { CharacterId = 17, Name = "Caustic", charactertypeId = 3 },
                new { CharacterId = 18, Name = "Wattson", charactertypeId = 3 },
                new { CharacterId = 19, Name = "Rampart", charactertypeId = 3 },
                new { CharacterId = 20, Name = "New Castle", charactertypeId = 3 },
                new { CharacterId = 21, Name = "Catalyst", charactertypeId = 3 },
               
                new { CharacterId = 22, Name = "Lifeline", charactertypeId = 4 },
                new { CharacterId = 23, Name = "Loba", charactertypeId = 4 }

            );
        }
    }
}
