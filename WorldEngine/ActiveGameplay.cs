using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class ActiveGameplay
    {
        //also for common messages the system may give the player

        public static void GameStart()
        {
            //TODO - initial game intro loop.
            WorldLoad.LoadWeapons();
            WorldLoad.LoadMonsters();
            WorldLoad.LoadRooms();
            WorldLoad.LoadPlayer();
            WorldLoad.LoadItems();
            WorldLoad.LoadPotions();
            WorldLoad.LoadTreasures();
        }

        public static void GameplayLoop()
        {
            Room room = World.FindRoomByID(World.players[0].PlayerLocation);
            string action;
            action = Console.ReadLine().ToLower();
            do
            {
                room = World.FindRoomByID(World.players[0].PlayerLocation);
                switch (action)
                {
                    case "north":
                    case "n":
                    case "south":
                    case "s":
                    case "east":
                    case "e":
                    case "west":
                    case "w":
                        Exploration.Movement(action, room);
                        break;
                    case "attack":
                        WorkingCombat.CombatLoop(World.players[0], room.Monsters[0]);
                        break;
                    //TODO Add a inventory command also need to update playercsv to have an inventory
                    default:
                        Console.WriteLine("Your body and mind are not sync. You cannot do that action");
                        break;
                }
            } while (action != "exit");
        }

        public static void ExitState()
        {
            Console.WriteLine("You feel yourself drift off. Until next time :)");
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        public static void GameOver()
        {
            //for when player dies in combat. TODO
        }

        public static void NormalState()
        {
            //TODO - initial statement between loops, such as inital information whent the player arrives in a room
        }
    }
}
