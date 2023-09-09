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
            using (var reader = new StreamReader(@"..\WorldEngine\CSVFiles\Player.csv"))
            {
                //skip first line
                //reader.ReadLine();

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

                    //this will be used for when player may have a different starting weapon
                    List<Weapon> weapon = new List<Weapon> { World.weapons.FirstOrDefault(w => w.IdNumber == weapons) };

                    //may change this if player is allowed to change weapon
                    Player player = new Player(id, name, race, location, hp, ac, weapon);
                    World.players.Add(player);
                }
            }
        }

        public static void LoadRooms()
        {
            using (StreamReader reader = new StreamReader(@"..\WorldEngine\CSVFiles\rooms.csv"))
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

                    Room room = new Room(id, name, description, exitNorth, exitSouth, exitEast, exitWest, exitUp, exitDown);
                    World.rooms.Add(room);
                }
            }
        }

        public static void LoadWeapons()
        {
            using (var reader = new StreamReader(@"..\WorldEngine\CSVFiles\weapons.csv"))
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
            using (var reader = new StreamReader(@"..\WorldEngine\CSVFiles\Monsters.csv"))
            {
                //skip first line when we add headers
                //reader.ReadLine();

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

    }
}
