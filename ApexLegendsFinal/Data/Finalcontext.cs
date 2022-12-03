using ApexLegendsFinal.Models.charater;
using ApexLegendsFinal.Models.guns;
using ApexLegendsFinal.Models.map;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_final.Models;

namespace Final_v1.Data
{
    public class Finalcontext : DbContext
    {
        public Finalcontext(DbContextOptions<Finalcontext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            _ = builder.Entity<Characters>().HasData
           (
                new Characters{ CharacterId = 1, Name = "Wraith",Description= "Interdementional Skirmisher", Ultimate = "Dimensional Rift", Heirloom = "Kunai" },
                new Characters{ CharacterId = 2, Name = "Bangalore", Description = "Professional Soldier", Ultimate = "Rolling Thunder", Heirloom = "Cold Steel" },
                new Characters { CharacterId = 3, Name = "Mirge", Description = "Holographic Trickster", Ultimate = "Life of The Party", Heirloom = "" },
                new Characters { CharacterId = 4, Name = "Octane", Description = "High-Speed DareDevil", Ultimate = "Launch Pad", Heirloom = "" },
                new Characters { CharacterId = 5, Name = "Revenant", Description = "Synthetic Nightmare", Ultimate = "Death Totem", Heirloom = "" },
                new Characters { CharacterId = 6, Name = "Horizon", Description = "Gravity Manipulator", Ultimate = "Black Hole", Heirloom = "" },
                new Characters { CharacterId = 7, Name = "Fuze", Description = "Explosive Enthusiast", Ultimate = "The Motherload", Heirloom = "" },
                new Characters { CharacterId = 8, Name = "Ash", Description = "Inclusive Instigator", Ultimate = "Phase Breach", Heirloom = "" },
                new Characters { CharacterId = 9, Name = "Mad Maggie", Description = "Rebel Warlord", Ultimate = "Wreching Ball", Heirloom = "" },

                new Characters { CharacterId = 10, Name = "Bloodhound", Description = "Technological Tracker", Ultimate = "Beast of the Hunt", Heirloom = "" },
                new Characters { CharacterId = 11, Name = "Pathfinder", Description = "Forward Scout", Ultimate = "ZipLine Gun", Heirloom = "" },
                new Characters { CharacterId = 12, Name = "Crypto", Description = "Surveillance Expert", Ultimate = "Drone EMP", Heirloom = "" },
                new Characters { CharacterId = 13, Name = "Valkyrie", Description = "Winged Avanger", Ultimate = "Skyward Dive", Heirloom = "" },
                new Characters { CharacterId = 14, Name = "Seer", Description = "Ambush Artist", Ultimate = "Exhibit", Heirloom = "" },
                new Characters { CharacterId = 15, Name = "Vantage", Description = "Survivalist Sniper", Ultimate = "Sniper's Mark", Heirloom = "" },

                new Characters { CharacterId = 16, Name = "Gibraltar", Description = "Shielded Fortress", Ultimate = "Defense Bombardment", Heirloom = "" },
                new Characters { CharacterId = 17, Name = "Caustic", Description = "Toxic Trapper", Ultimate = "Nox Gas Granade", Heirloom = "" },
                new Characters { CharacterId = 18, Name = "Wattson", Description = "Interception Pylon", Ultimate = "" },
                new Characters { CharacterId = 19, Name = "Rampart", Description = "Base of Fire", Ultimate = "Mobile Minigun SHEILA", Heirloom = "" },
                new Characters { CharacterId = 20, Name = "New Castle", Description = "Mobile Guardian", Ultimate = "Castle Wall", Heirloom = "" },
                new Characters { CharacterId = 21, Name = "Catalyst", Description = "Defense Conjurer", Ultimate = "Dark Veil", Heirloom = "" },

                new Characters { CharacterId = 22, Name = "Lifeline", Description = "Combat Medic", Ultimate = "Care Package", Heirloom = "" },
                new Characters { CharacterId = 23, Name = "Loba", Description = "Translocating Thief", Ultimate = "Black Market Boutique", Heirloom = "" }
            );
            
            builder.Entity<Weapons>().HasData
            (
                new Weapons { WeaponId = 1, Name = "R-301 Carbine",Description = "Light Ammo",Type = "Assault" },
                new Weapons { WeaponId = 2, Name = "VK-47 Flatline", Description = "Heavy Ammo", Type = "Assault" },
                new Weapons { WeaponId = 3, Name = "Havoc Rifle", Description = "Energy Ammo", Type = "Assault" },
                new Weapons { WeaponId = 4, Name = "Hemlock Burst AR", Description = "Heavy Ammo", Type = "Assault" },

                new Weapons { WeaponId = 5, Name = "Alternator", Description = "Light Ammo", Type = "SMG" },
                new Weapons { WeaponId = 6, Name = "Prowler Burst PWD", Description = "Heavy Ammo", Type = "SMG" },
                new Weapons { WeaponId = 7, Name = "R-99 SMG", Description = "Light Ammo", Type = "SMG" },
                new Weapons { WeaponId = 8, Name = "Volt SMG", Description = "Energy Ammo", Type = "SMG" },
                new Weapons { WeaponId = 9, Name = "C.A.R. SMG", Description = "Heavy/Light Ammo", Type = "SMG" },

                new Weapons { WeaponId = 10, Name = "Devotion LMG", Description = "Energy Ammo", Type = "LMG" },
                new Weapons { WeaponId = 11, Name = "L-Star EMG", Description = "Energy Ammo", Type = "LMG" },
                new Weapons { WeaponId = 12, Name = "M600 Spitfire", Description = "Light Ammo", Type = "LMG" },
                new Weapons { WeaponId = 13, Name = "Rampage", Description = "Heavy Ammo" , Type = "LMG" },

                new Weapons { WeaponId = 14, Name = "G7 Scout", Description = "Light Ammo", Type = "Marksman" },
                new Weapons { WeaponId = 15, Name = "Triple Take", Description = "Energy Ammo", Type = "Marksman" },
                new Weapons { WeaponId = 16, Name = "30-30 Repeater", Description = "Heavy Ammo", Type = "Marksman" },
                new Weapons { WeaponId = 17, Name = "Bocek Compound Bow", Description = "Arrows", Type = "Marksman" },

                new Weapons { WeaponId = 18, Name = "Charge Rifle", Description = "Sniper Ammo", Type = "Sniper"},
                new Weapons { WeaponId = 19, Name = "Longbow DMR", Description = "Sniper Ammo", Type = "Sniper" },
                new Weapons { WeaponId = 20, Name = "Kraber .50-cal Sniper", Description = "Sniper Ammor", Type = "Sniper" },
                new Weapons { WeaponId = 21, Name = "Sentinal", Description = "Sniper Ammo", Type = "Sniper" },

                new Weapons { WeaponId = 22, Name = "Eva-8 Auto", Description = "Shotgun Ammo", Type = "Shotgun" },
                new Weapons { WeaponId = 23, Name = "Masriff Shotgun", Description = "Shotgun Ammo", Type = "Shotgun" },
                new Weapons { WeaponId = 24, Name = "Mozambique", Description = "Shotgun Ammo", Type = "Shotgun" },
                new Weapons { WeaponId = 25, Name = "Peacekeeper", Description = "Shotgun Ammo", Type = "Shotgun" },

                new Weapons { WeaponId = 26, Name = "Re-45 Auto", Description = "Light Ammo", Type = "Pistol" },
                new Weapons { WeaponId = 27, Name = "P2020", Description = "Light Ammo", Type = "Pistol" },
                new Weapons { WeaponId = 28, Name = "Wingman", Description = "Sniper Ammo", Type = "Pistol" }
            );
           
            builder.Entity<Maps>().HasData
            (
                 new Maps { MapId = 1, Name = "Kings Canyon", Description = "An Island on the settlement Solace, first home of the Apex Games", Type= "Battle Royale"},
                 new Maps { MapId = 2, Name = "World's Edge", Description = "Planet Talos beset by intense volcanic activity", Type = "Battle Royale" },
                 new Maps { MapId = 3, Name = "Olympus", Description = "City built on dreams, Olympus is a floating arena above Psamathe", Type =  "Battle Royale" },
                 new Maps { MapId = 4, Name = "Storm Point", Description = "A Deserted island or so it was taught, home of many creatures and one of the new additions to the Apex Games", Type = "Battle Royale" },
                 new Maps { MapId = 5, Name = "Broken Moon", Description = "The newest addition to the Apex Games, Once a moon until a meteor and myth broke it apart", Type = "Battle Royale" },

                 new Maps { MapId = 6, Name = "Drop Off", Description = "One of the tallest buildings in Malta is the fully automated Hammond Manufacturing Tower", Type = "Arenas" },
                 new Maps { MapId = 7, Name = "Habit 4", Description = "One of the smaller islands in the chain, and is best known as a leviathan breeding ground", Type = "Arenas" },
                 new Maps { MapId = 8, Name = "Encore", Description = "Found on the planet Boreas, it is the Arena where Seer made his name", Type = "Arenas" },
                 new Maps { MapId = 9, Name = "OverFlow", Description = "Arena/mining rig where combat never stops", Type = "Arenas" },
                 new Maps { MapId = 10, Name = "Party Crasher", Description = "Arena only exists becuase Mirage crashed his Mirage Voyage into a plaza, One side ship, other side shopping center" },
                 new Maps { MapId = 11, Name = "Phase Runner", Description = "Arena where you have a prototype phase runner that is still functioning, an abandoned area where no one want ownership", Type = "Arenas" }
            );
        
        builder.Entity<Rank>().HasData
           (
                 new Rank{ RankId = 1, Rookie = "Rookie"},
                 new Rank{ RankId = 2, Gold = "Gold"},
                 new Rank{ RankId = 3, Diamond = "Diamond"}
            );
        }

        public DbSet<Characters> Characters { get; set; }
        public DbSet<Weapons> Weapons { get; set; }
        public DbSet<Maps> Maps { get; set; }
        public DbSet<Rank> Rank { get; set; }
    }
}
