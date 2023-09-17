using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorldEngine
{
    public class WorldLoad
    {
        public static void LoadPlayer()
        {
            using (var reader = new StreamReader(@"..\..\..\WorldEngine\CSVFiles\Player.csv"))
            {
                //skip first line
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var row = reader.ReadLine().Split(',');

                    int id = int.Parse(row[0]);
                    string name = row[1];
                    string race = row[2];
                    int location = int.Parse(row[3]);
                    int hp = int.Parse(row[4]);
                    int ac = int.Parse(row[5]);
                    int weapons = row[6] != "" ? weapons = int.Parse(row[6]) : weapons = 0;
                    int items = row[7] != "" ? items = int.Parse(row[7]) : items = 0;
                    int potions = row[8] != "" ? potions = int.Parse(row[8]) : potions = 0;
                    int treasures = row[9] != "" ? treasures = int.Parse(row[9]) : treasures = 0;

                    //this will be used for when player may have a different starting weapon
                    List<Weapon> weapon = new List<Weapon> { World.weapons.FirstOrDefault(w => w.IdNumber == weapons) };
                    List<Items> item = new List<Items> { World.items.FirstOrDefault(i => i.IdNumber == items) };
                    List<Potion> potion = new List<Potion> { World.potion.FirstOrDefault(p => p.IdNumber == potions) };
                    List<Treasures> treasure = new List<Treasures> { World.treasures.FirstOrDefault(t => t.IdNumber == treasures) };

                    //may change this if player is allowed to change weapon
                    Player player = new Player(id, name, race, location, hp, ac, weapon, item, potion, treasure);
                    World.players.Add(player);
                }
            }
        }

        public static void LoadRooms()
        {
            using (StreamReader reader = new StreamReader(@"..\..\..\WorldEngine\CSVFiles\rooms.csv"))
            {
                List<Room> list = new List<Room>();

                //no column header line
                //reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var data = reader.ReadLine().Split(',');

                    int id = int.Parse(data[0]);
                    string name = data[1];
                    string description = data[2];
                    int exitNorth = int.Parse(data[3]);
                    int exitSouth = int.Parse(data[4]);
                    int exitEast = int.Parse(data[5]);
                    int exitWest = int.Parse(data[6]);
                    int exitUp = int.Parse(data[7]);
                    int exitDown = int.Parse(data[8]);
                    int potions = data[9] != "" ? potions = int.Parse(data[9]) : potions = 0;
                    int weapons = data[10] != "" ? weapons = int.Parse(data[10]) : weapons = 0;
                    int monsters = data[11] != "" ? monsters = int.Parse(data[11]) : monsters = 0;
                    int treasures = data[12] != "" ? treasures = int.Parse(data[12]) : treasures = 0;
                    int items = data[13] != "" ? items = int.Parse(data[13]) : items = 0;

                    List<Potion> potion = data[9] != "0" ? new List<Potion> { World.potion.FirstOrDefault(p => p.IdNumber == potions) } : new List<Potion>();
                    List<Weapon> weapon = data[10] != "0" ? new List<Weapon> { World.weapons.FirstOrDefault(w => w.IdNumber == weapons) } : new List<Weapon>();
                    List<Monster> monster = data[11] != "0" ? new List<Monster> { World.monsters.FirstOrDefault(m => m.IdNumber == monsters) } : new List<Monster>();
                    List<Treasures> treasure = data[12] != "0" ? new List<Treasures> { World.treasures.FirstOrDefault(t => t.IdNumber == treasures) } : new List<Treasures>();
                    List<Items> item = data[13] != "0" ? new List<Items> { World.items.FirstOrDefault(i => i.IdNumber == items) } : new List<Items>();

                    Room room = new Room(id, name, description, exitNorth, exitSouth, exitEast, exitWest, exitUp, exitDown, potion, weapon, monster, treasure, item);
                    World.rooms.Add(room);
                }
                //adding to Dictionary
                int nextRoomID = 101; //dw, it's needed
                foreach (var room in World.rooms)
                {
                    int roomID = nextRoomID;

                    World.roomDict.Add(roomID, room);

                    nextRoomID++;
                }
            }
        }

        public static void LoadWeapons()
        {
            using (var reader = new StreamReader(@"..\..\..\WorldEngine\CSVFiles\weapons.csv"))
            {
                //no first line headers in file, may change later
                //reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var row = reader.ReadLine().Split(',');

                    int id = int.Parse(row[0]);
                    string name = row[1];
                    string damage = row[2];
                    string damageType = row[3];
                    int price = int.Parse(row[4]);

                    Weapon weapon = new Weapon(id, name, damage, damageType, price);
                    World.weapons.Add(weapon);
                }
            }

        }

        public static void LoadMonsters()
        {
            using (var reader = new StreamReader(@"..\..\..\WorldEngine\CSVFiles\Monsters.csv"))
            {
                //skips first line headers
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var row = reader.ReadLine().Split(',');

                    int id = int.Parse(row[0]);
                    string name = row[1];
                    string description = row[2];
                    string race = row[3];
                    int hp = int.Parse(row[4]);
                    int ac = int.Parse(row[5]);
                    int weaponID = int.Parse(row[6]);

                    Weapon weapon = World.weapons.FirstOrDefault(w => w.IdNumber == weaponID);

                    Monster monster = new Monster(id, name, description, race, hp, ac, weapon);
                    World.monsters.Add(monster);
                }
            }
        }

        public static void LoadItems()
        {


            using (var reader = new StreamReader(@"..\..\..\WorldEngine\CSVFiles\Items.csv"))
            {
                //skips first line headers
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var row = reader.ReadLine().Split(',');

                    int id = int.Parse(row[0]);
                    string name = row[1];
                    string description = row[2];


                    Items item = new Items(id, name, description);
                    World.items.Add(item);
                }
            }
        }

        public static void LoadTreasures()
        {


            using (var reader = new StreamReader(@"..\..\..\WorldEngine\CSVFiles\Treasures.csv"))
            {
                //skips first line headers
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var row = reader.ReadLine().Split(',');

                    int id = int.Parse(row[0]);
                    string name = row[1];
                    string description = row[2];
                    string value = row[3];

                    Treasures treasure = new Treasures(id, name, value);
                    World.treasures.Add(treasure);
                }

            }
        }
        public static void LoadPotions()
        {


            using (var reader = new StreamReader(@"..\..\..\WorldEngine\CSVFiles\potions.csv"))
            {
                //skips first line headers
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var row = reader.ReadLine().Split(',');

                    int id = int.Parse(row[0]);
                    string name = row[1];
                    string description = row[2];
                    int value = int.Parse(row[3]);


                    Potion potions = new Potion(id, name, description, value);
                    World.potion.Add(potions);
                }

            }
        }
    }
}