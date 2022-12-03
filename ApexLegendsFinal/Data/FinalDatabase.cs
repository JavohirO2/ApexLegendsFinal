using ApexLegendsFinal.Models.charater;
using ApexLegendsFinal.Models.guns;
using ApexLegendsFinal.Models.map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_final.Models;

namespace Final_v1.Data
{
    public class FinalDatabase
    {
        private Finalcontext _context;
        public FinalDatabase(Finalcontext context)
        {
            _context = context;
        }
        //Character table
        public IEnumerable<Characters> GetByCharacterId(int id)
        {
            if (id == 0)
            {
                return _context.Characters.Take(23);
            }
            return _context.Characters.Where(x => x.CharacterId == id);
        }
        public void AddCharacter(Characters characters)
        {
            _context.Characters.Add(characters);
        }
        public IEnumerable<Characters> GetCharacter()
        {
            return _context.Characters.ToList();
        }
        public void AddNewCharacter(Characters characters)
        {
            try
            {
                _context.Characters.Add(characters);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Characters DeleteCharactersDatabase(string  Name)
        {
            var characterToDelete = _context.Characters.First(x => x.Name == Name);
            if (characterToDelete != null)
            {
                _context.Remove(characterToDelete);
                _context.SaveChanges();
            }
            return characterToDelete;
        }
        public Characters UpdatecCharacters(Characters characters)
        {
            var updateCollection = _context.Characters.First(x => x.Name == characters.Name);
            if (updateCollection != null)
            {
                updateCollection.Name = characters.Name;
                updateCollection.Description = characters.Description;
                updateCollection.Heirloom = characters.Heirloom;
                updateCollection.Ultimate = characters.Ultimate;
                _context.SaveChanges();
            }
            return updateCollection;
        }
        //Weapon table
        public IEnumerable<Weapons> GetByWeapons(int id)
        {
            if (id == 0)
            {
                return _context.Weapons.Take(28);
            }
            return _context.Weapons.Where(x => x.WeaponId == id);
        }
        public void AddWeapons(Weapons weapons)
        {
            _context.Weapons.Add(weapons);
        }
        public IEnumerable<Weapons> GetAllWeapons()
        {
            return _context.Weapons.ToList();
        }
        public void AddNewWeapons(Weapons weapons)
        {
            try
            {
                _context.Weapons.Add(weapons);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Weapons DeleteWeapons(string weapons)
        {
            var weaponsToDelete = _context.Weapons.First(x => x.Name == weapons);
            if(weaponsToDelete != null)
            {
                _context.Remove(weaponsToDelete);
                _context.SaveChanges();
            }
            return weaponsToDelete;
        }
        public Weapons UpdateWeapons(Weapons weapons)
        {
            var updateCollection = _context.Weapons.First(x => x.Name == weapons.Name);
            if(updateCollection != null)
            {
                updateCollection.Name = weapons.Name;
                updateCollection.Description = weapons.Description;
                updateCollection.Type = weapons.Type;
                _context.SaveChanges();
            }
            return updateCollection;
        }
        // Map table
        public IEnumerable<Maps> GetByMapId(int id)
        {
            if (id == 0)
            {
                return _context.Maps.Take(5);
            }
            return _context.Maps.Where(x => x.MapId == id);
        }
        public void AddAnime(Maps maps)
        {
            _context.Maps.Add(maps);
        }
        public IEnumerable<Maps> GetMaps()
        {
            return _context.Maps.ToList();
        }
        public void AddNewMaps(Maps maps)
        {
            try
            {
                _context.Maps.Add(maps);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Maps DeleteMaps(string maps)
        {
            var MapsToDelete = _context.Maps.First(x => x.Name == maps);
            if (MapsToDelete != null)
            {
                _context.Remove(MapsToDelete);
                _context.SaveChanges();
            }
            return MapsToDelete;
        }
        public Maps UpdateMaps(Maps maps)
        {
            var updateCollection = _context.Maps.First(x => x.Name == maps.Name);
            if (updateCollection != null)
            {
                updateCollection.Name = maps.Name;
                updateCollection.Description = maps.Description;
                updateCollection.Type = maps.Type;
                _context.SaveChanges();
            }
            return updateCollection;
        }
        // Rank table
        public IEnumerable<Rank> GetByRankId(int id)
        {
            if (id == 0)
            {
                return _context.Rank.Take(5);
            }
            return _context.Rank.Where(x => x.RankId == id);
        }
        public void AddRank(Rank rank)
        {
            _context.Rank.Add(rank);
        }
        public IEnumerable<Rank> GetRank()
        {
            return _context.Rank.ToList();
        }
        public void AddNewRank(Rank rank)
        {
            try
            {
                _context.Rank.Add(rank);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Rank DeleteRank(string Name)
        {
            var RankToDelete = _context.Rank.First(x => x.Rookie == Name);
            if (RankToDelete != null)
            {
                _context.Remove(RankToDelete);
                _context.SaveChanges();
            }
            return RankToDelete;
        }
        public Rank UpdateRank(Rank rank)
        {
            var updateCollection = _context.Rank.First(x => x.Rookie == rank.Rookie);
            if (updateCollection != null)
            {
                updateCollection.Rookie = rank.Rookie;
                updateCollection.Silver= rank.Silver;
                updateCollection.Gold= rank.Gold;
                updateCollection.Platinum = rank.Platinum;
                updateCollection.Diamond = rank.Diamond;
                updateCollection.Master = rank.Master;
                updateCollection.Predator = rank.Predator;
                _context.SaveChanges();
            }
            return updateCollection;
        }

    }
}
