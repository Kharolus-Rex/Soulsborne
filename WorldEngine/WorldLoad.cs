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

        }

        public static void LoadRooms()
        {
            using (StreamReader reader = new StreamReader("filepath"))
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
            using (var reader = new StreamReader("filepath"))
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

        }

    }
}
