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

        public static void CollectThings()
        {
            //TODO - add a command to collect items and things in a room
        }
    }
}
