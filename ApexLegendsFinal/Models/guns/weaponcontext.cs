using Microsoft.EntityFrameworkCore;
using ApexLegendsFinal.Models.guns;

namespace ApexLegendsFinal.Models.charater
{
    public class weaponcontext
    {
        public DbSet<Apex_weapons> Weapons { get; set; }
        public DbSet<weapontype> WeaponType { get; set; }

        protected  void OnModelCreating(ModelBuilder modelBuilder)
        {
           // base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<weapontype>().HasData(
                new weapontype { weapontypeId = 1, Name = "Assault" },
                new weapontype { weapontypeId = 2, Name = "SMG" },
                new weapontype { weapontypeId = 3, Name = "LMG" },
                new weapontype { weapontypeId = 4, Name = "Marksman" },
                new weapontype { weapontypeId = 5, Name = "Sniper" },
                new weapontype { weapontypeId = 6, Name = "Pistol" },
                new weapontype { weapontypeId = 7, Name = "Shotgun" }
                );
            modelBuilder.Entity<Apex_weapons>().HasData(
                new { WeaponId = 1, Name = "R-301 Carbine", weapontypeId = 1 },
                new { WeaponId = 2, Name = "VK-47 Flatline", weapontypeId = 1 },
                new { WeaponId = 3, Name = "Havoc Rifle", weapontypeId = 1 },
                new { WeaponId = 4, Name = "Hemlock Burst AR", weapontypeId = 1 },
                
                new { WeaponId = 5, Name = "Alternator", weapontypeId = 2 },
                new { WeaponId = 6, Name = "Prowler Burst PWD", weapontypeId = 2 },
                new { WeaponId = 7, Name = "R-99 SMG", weapontypeId = 2 },
                new { WeaponId = 8, Name = "Volt SMG", weapontypeId = 2 },
                new { WeaponId = 9, Name = "C.A.R. SMG", weapontypeId = 2 },
               
                new { WeaponId = 10, Name = "Devotion LMG", weapontypeId = 3 },
                new { WeaponId = 11, Name = "L-Star EMG", weapontypeId = 3 },
                new { WeaponId = 12, Name = "M600 Spitfire", weapontypeId = 3 },
                new { WeaponId = 13, Name = "Rampage", weapontypeId = 3 },
                
                new { WeaponId = 14, Name = "G7 Scout", weapontypeId = 4 },
                new { WeaponId = 15, Name = "Triple Take", weapontypeId = 4 },
                new { WeaponId = 16, Name = "30-30 Repeater", weapontypeId = 4 },
                new { WeaponId = 17, Name = "Bocek Compound Bow", weapontypeId = 4 },

                new { WeaponId = 18, Name = "Charge Rifle", weapontypeId = 5 },
                new { WeaponId = 19, Name = "Longbow DMR", weapontypeId = 5 },
                new { WeaponId = 20, Name = "Kraber .50-cal Sniper", weapontypeId = 5 },
                new { WeaponId = 21, Name = "Sentinal", weapontypeId = 5 },
                
                new { WeaponId = 22, Name = "Eva-8 Auto", weapontypeId = 6 },
                new { WeaponId = 23, Name = "Masriff Shotgun", weapontypeId = 6 },
                new { WeaponId = 24, Name = "Mozambique", weapontypeId = 6 },
                new { WeaponId = 25, Name = "Peacekeeper", weapontypeId = 6 },
                
                new { WeaponId = 26, Name = "Re-45 Auto", weapontypeId = 7 },
                new { WeaponId = 27, Name = "P2020", weapontypeId = 7 },
                new { WeaponId = 28, Name = "Wingman", weapontypeId = 7 }
            );
        }
    }
}