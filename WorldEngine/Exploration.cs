using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class Exploration
    {
        public static void Movement(string Direction, Room room)
        {
            switch (Direction)
            {
                case "north":
                case "n":
                    if (room.ExitNorth == -1)
                    {
                        Console.WriteLine("\nA wall is in that direction. You can't break that wall!");
                        break;
                    }
                    else
                    {
                        int nextRoom = room.ExitNorth;
                        World.players[0].PlayerLocation = nextRoom; //updates player location with next room, which is what the exit[0] is, the north exit.
                    }
                    break;
                case "south":
                case "s":
                    if (room.ExitSouth == -1)
                    {
                        Console.WriteLine("\nA wall is in that direction. You can't break that wall!");
                        break;
                    }
                    else
                    {
                        int nextRoom = room.ExitSouth;
                        World.players[0].PlayerLocation = nextRoom; //updates player location with next room, which is what the exit[1] is, the south exit.
                    }
                    break;
                case "east":
                case "e":
                    if (room.ExitEast == -1)
                    {
                        Console.WriteLine("\nA wall is in that direction. You can't break that wall!");
                        break;
                    }
                    else
                    {
                        int nextRoom = room.ExitEast;
                        World.players[0].PlayerLocation = nextRoom; //updates player location with next room, which is what the exit[2] is, the east exit.
                    }
                    break;
                case "west":
                case "w":
                    if (room.ExitWest == -1)
                    {
                        Console.WriteLine("\nA wall is in that direction. You can't break that wall!");
                        break;
                    }
                    else
                    {
                        int nextRoom = room.ExitWest;
                        World.players[0].PlayerLocation = nextRoom; //updates player location with next room, which is what the exit[3] is, the west exit.
                    }
                    break;
                case "up":
                case "u":
                    if (room.ExitUp == -1)
                    {
                        Console.WriteLine("\nThere is no stairway or ladder leading up.");
                        break;
                    }
                    else
                    {
                        int nextRoom = room.ExitUp;
                        World.players[0].PlayerLocation = nextRoom;
                    }
                    break;
                case "down":
                case "d":
                    if (room.ExitDown == -1)
                    {
                        Console.WriteLine("\nThere is no stairway or ladder leading up.");
                        break;
                    }
                    else
                    {
                        int nextRoom = room.ExitDown;
                        World.players[0].PlayerLocation = nextRoom;
                    }
                    break;
                default:
                    Console.WriteLine("A wall of force blocks your movement in that direction. Where else could you go?");
                    break;
            }
            return;
        }

        public static void CollectThings(Room room, Player player)
        {
            //TODO - add a command to collect items and things in a room
            for (int i = 0; i < room.Items.Count; i++)
            {
                player.Item.Add(room.Items[i]);
                room.Items.RemoveAt(i);
                //this adds the item to player and removes it from the room
            }
            for (int i = 0; i < room.Potions.Count; i++)
            {
                player.Potions.Add(room.Potions[i]);
                room.Potions.RemoveAt(i);
            }
            for (int i = 0; i < room.Weapons.Count; i++)
            {
                player.Weapons.Add(room.Weapons[i]);
                room.Weapons.RemoveAt(i);
            }
            for (int i = 0; i < room.Treasures.Count; i++)
            {
                player.Treasure.Add(room.Treasures[i]);
                room.Treasures.RemoveAt(i);
            }
            return;
        }

        public static void LookAround()
        {
            Room room = World.FindRoomByID(World.players[0].PlayerLocation);
            //display mods, items, etc.
            Console.WriteLine();
            if (room.Monsters != null && room.Monsters.Count > 0)
            {
                Console.WriteLine("Monsters present:");
                foreach (Monster monster in room.Monsters)
                {
                    Console.WriteLine($" - {monster.Name}");
                }
            }

            if (room.Items != null && room.Items.Count > 0)
            {
                Console.WriteLine("Items:");
                foreach (Items item in room.Items)
                {
                    Console.WriteLine($" - {item.Name}");
                }
            }

            if (room.Weapons != null && room.Weapons.Count > 0)
            {
                Console.WriteLine("Weapons:");
                foreach (Weapon weapon in room.Weapons)
                {
                    Console.Write($" - {weapon.Name}");
                }
            }

            if (room.Treasures != null && room.Treasures.Count > 0)
            {
                Console.WriteLine("Treasures:");
                foreach (Treasures treasure in room.Treasures)
                {
                    Console.WriteLine($" -  {treasure.Name}");
                }
            }
            return;
        }
    }
}
