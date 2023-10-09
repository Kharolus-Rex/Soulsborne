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
        public static readonly List<Room> rooms = new List<Room>();
        public static readonly List<Weapon> weapons = new List<Weapon>();
        public static readonly List<Monster> monsters = new List<Monster>();
        public static readonly List<Player> players = new List<Player>();
        public static readonly List<Potion> potion = new List<Potion>();
        public static readonly List<Treasures> treasures = new List<Treasures>();
        public static readonly List<Items> items = new List<Items>();

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
