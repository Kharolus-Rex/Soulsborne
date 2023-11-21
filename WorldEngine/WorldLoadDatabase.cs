using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace WorldEngine
{
    public static class WorldLoadDatabase
    {
        
        public static void LoadWeapons()
        {
            string dbfile = "URI=file:classesDB.db";
            using (SQLiteConnection connection = new SQLiteConnection(dbfile))
            {
                //var output = cnn.Query<Weapon>("select * from Weapons", new DynamicParameters());
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand("select * from Weapons", connection);
                SQLiteDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int ID = dataReader.GetInt32(0);
                    string name = dataReader.GetString(1);
                    string damage = dataReader.GetString(2);
                    string damageType = dataReader.GetString(3);
                    int price = dataReader.GetInt32(4);
                    Weapon weapon = new Weapon(ID, name, damage, damageType, price);
                    World.weapons.Add(weapon);
                }
            }
        }
        public static void LoadMonsters()
        {
            string dbfile = "URI=file:classesDB.db";
            using (SQLiteConnection connection = new SQLiteConnection(dbfile))
            {
                //var output = cnn.Query<Weapon>("select * from Monsters", new DynamicParameters());
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand("select * from Monsters", connection);
                SQLiteDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int ID = dataReader.GetInt32(0);
                    string name = dataReader.GetString(1);
                    string description = dataReader.GetString(2);
                    string race = dataReader.GetString(3);
                    int hp = dataReader.GetInt32(4);
                    int ac = dataReader.GetInt32(5);
                    int weaponID = dataReader.GetInt32(6);

                    Weapon weapon = World.weapons.FirstOrDefault(w => w.IdNumber == weaponID);

                    Monster monster = new Monster(ID, name, description, race, hp, ac, weapon);
                    World.monsters.Add(monster);
                }
            }
        }
        public static void LoadRooms()
        {
            string dbfile = "URI=file:classesDB.db";
            using (SQLiteConnection connection = new SQLiteConnection(dbfile))
            {
                //var output = cnn.Query<Room>("select * from Rooms", new DynamicParameters());
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand("select * from Rooms", connection);
                SQLiteDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int ID = dataReader.GetInt32(0);
                    string name = dataReader.GetString(1);
                    string description = dataReader.GetString(2);
                    int exitNorth = dataReader.GetInt32(3);
                    int exitSouth = dataReader.GetInt32(4);
                    int exitEast = dataReader.GetInt32(5);
                    int exitWest = dataReader.GetInt32(6);
                    int exitUp = dataReader.GetInt32(7);
                    int exitDown = dataReader.GetInt32(8);
                    int potions = dataReader.GetString(9) != "" ? potions = int.Parse(dataReader.GetString(9)) : potions = 0;
                    int weapons = dataReader.GetString(10) != "" ? weapons = int.Parse(dataReader.GetString(10)) : weapons = 0;
                    int monsters = dataReader.GetString(11) != "" ? monsters = int.Parse(dataReader.GetString(11)) : monsters = 0;
                    int treasures = dataReader.GetString(12) != "" ? treasures = int.Parse(dataReader.GetString(12)) : treasures = 0;
                    int items = dataReader.GetString(13) != "" ? items = int.Parse(dataReader.GetString(9)) : items = 0;

                    List<Potion> potion = dataReader.GetString(9) != "0" ? new List<Potion> { World.potion.FirstOrDefault(p => p.ID == potions) } : new List<Potion>();
                    List<Weapon> weapon = dataReader.GetString(10) != "0" ? new List<Weapon> { World.weapons.FirstOrDefault(w => w.IdNumber == weapons) } : new List<Weapon>();
                    List<Monster> monster = dataReader.GetString(11) != "0" ? new List<Monster> { World.monsters.FirstOrDefault(m => m.ID == monsters) } : new List<Monster>();
                    List<Treasures> treasure = dataReader.GetString(12) != "0" ? new List<Treasures> { World.treasures.FirstOrDefault(t => t.ID == treasures) } : new List<Treasures>();
                    List<Items> item = dataReader.GetString(13) != "0" ? new List<Items> { World.items.FirstOrDefault(i => i.IdNumber == items) } : new List<Items>();
                    Room room = new Room(ID, name, description, exitNorth, exitSouth, exitEast, exitWest, exitUp, exitDown, potion, weapon, monster, treasure, item);
                    World.rooms.Add(room);
                }
            }
        }
        public static void LoadPlayers()
        {
            string dbfile = "URI=file:classesDB.db";
            using (SQLiteConnection connection = new SQLiteConnection(dbfile))
            {
                //var output = cnn.Query<Player>("select * from Players", new DynamicParameters());
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand("select * from Players", connection);
                SQLiteDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int ID = dataReader.GetInt32(0);
                    string name = dataReader.GetString(1);
                    string race = dataReader.GetString(2);
                    int location = dataReader.GetInt32(3);
                    int hp = dataReader.GetInt32(4);
                    int ac = dataReader.GetInt32(5);
                    int weapons = dataReader.GetString(6) != "" ? weapons = int.Parse(dataReader.GetString(6)) : weapons = 0;
                    int items = dataReader.GetString(7) != "" ? items = int.Parse(dataReader.GetString(9)) : items = 0;
                    int potions = dataReader.GetString(8) != "" ? potions = int.Parse(dataReader.GetString(8)) : potions = 0;
                    int treasures = dataReader.GetString(9) != "" ? treasures = int.Parse(dataReader.GetString(9)) : treasures = 0;

                    List<Weapon> weapon = new List<Weapon> { World.weapons.FirstOrDefault(w => w.IdNumber == weapons) };
                    List<Items> item = new List<Items> { World.items.FirstOrDefault(i => i.IdNumber == items) };
                    List<Potion> potion = new List<Potion> { World.potion.FirstOrDefault(p => p.ID == potions) };
                    List<Treasures> treasure = new List<Treasures> { World.treasures.FirstOrDefault(t => t.ID == treasures) };

                    Player player = new Player(ID, name, race, location, hp, ac, weapon, item, potion, treasure);
                    World.players.Add(player);
                }
            }
        }
        public static void LoadItems()
        {
            string dbfile = "URI=file:classesDB.db";
            using (SQLiteConnection connection = new SQLiteConnection(dbfile))
            {
                //var output = cnn.Query<Items>("select * from Items", new DynamicParameters());
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand("select * from items", connection);
                SQLiteDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int ID = dataReader.GetInt32(0);
                    string name = dataReader.GetString(1);
                    string description = dataReader.GetString(2);
                    Items item = new Items(ID, name, description);
                    World.items.Add(item);
                }
            }
        }
        public static void LoadPotions()
        {
            string dbfile = "URI=file:classesDB.db";
            using (SQLiteConnection connection = new SQLiteConnection(dbfile))
            {
                //var output = cnn.Query<Potion>("select * from Potions", new DynamicParameters());
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand("select * from Potions", connection);
                SQLiteDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int ID = dataReader.GetInt32(0);
                    string name = dataReader.GetString(1);
                    string description = dataReader.GetString(2);
                    int value = dataReader.GetInt32(3);

                    Potion potions = new Potion(ID, name, description, value);
                    World.potion.Add(potions);
                }
            }
        }
        public static void LoadTreasures()
        {
            string dbfile = "URI=file:classesDB.db";
            using (SQLiteConnection connection = new SQLiteConnection(dbfile))
            {
                //var output = cnn.Query<Treasures>("select * from Treasures", new DynamicParameters());
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand("select * from Treasures", connection);
                SQLiteDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int ID = dataReader.GetInt32(0);
                    string name = dataReader.GetString(1);
                    int value = dataReader.GetInt32(2);

                    Treasures treasure = new Treasures(ID, name, value); ;
                    World.treasures.Add(treasure);
                }
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
