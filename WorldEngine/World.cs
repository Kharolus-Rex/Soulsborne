using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    /* In this area will exist all of the lists
     * for things such as Weapons, Rooms, Items
     * Treasures, Monsters, etc.
     * 
     */

    public static class World
    {
        //public static void WorldList()
        //{
        //List<Room> rooms = WorldLoadDatabase.LoadRooms();
        //List<Weapon> weapons = WorldLoadDatabase.LoadWeapons();
        //List<Monster> monsters = WorldLoadDatabase.LoadMonsters();
        //List<Player> players = WorldLoadDatabase.LoadPlayers();
        //List<Potion> potion = WorldLoadDatabase.LoadPotions();
        //List<Treasures> treasures = WorldLoadDatabase.LoadTreasures();
        //List<Items> items = WorldLoadDatabase.LoadItems();
        //}
        public static readonly List<Room> rooms = WorldLoadDatabase.LoadRooms();
        public static readonly List<Weapon> weapons = WorldLoadDatabase.LoadWeapons();
        public static readonly List<Monster> monsters = WorldLoadDatabase.LoadMonsters();
        public static readonly List<Player> players = WorldLoadDatabase.LoadPlayers();
        public static readonly List<Potion> potion = WorldLoadDatabase.LoadPotions();
        public static readonly List<Treasures> treasures = WorldLoadDatabase.LoadTreasures();
        public static readonly List<Items> items = WorldLoadDatabase.LoadItems();

        

        public static Dictionary<int, Room> roomDict = new Dictionary<int, Room>();
        public static Dictionary<int, Items> itemDict = new Dictionary<int, Items>();
        public static Dictionary<int, Potion> potionDict = new Dictionary<int, Potion>();
        public static Dictionary<int, Treasures> treasureDict = new Dictionary<int, Treasures>();

        public static Room FindRoomByID(int roomId)
        {
            foreach (Room room in World.rooms)
            {
                if (room.IdNumber == roomId)
                {
                    return room;
                }
            }
            return null;
        }

        #region Items
        public static Items ItemByID(int id)
        {
            return items.SingleOrDefault(x => x.IdNumber == id);
        }
        public static Items ItemByName(string name)
        {
            return items.SingleOrDefault(x => x.Name == name);
        }
        #endregion
        #region Monster
        public static Monster MonsterByID(int id)
        {
            return monsters.SingleOrDefault(x => x.ID == id);
        }
        public static Monster MonsterByName(string name)
        {
            return monsters.SingleOrDefault(x => x.Name == name);
        }
        #endregion
        #region Weapon
        public static Weapon WeaponByID(int id)
        {
            return weapons.SingleOrDefault(x => x.IdNumber == id);
        }
        public static Weapon WeaponByName(string name)
        {
            return weapons.SingleOrDefault(x => x.Name == name);
        }
        #endregion
    }
}
