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
            Console.WriteLine("𝕎𝕖𝕝𝕔𝕠𝕞𝕖 𝕥𝕠 𝕊𝕠𝕦𝕝𝕤𝕓𝕠𝕣𝕟𝕖");
        }

        public static void GameplayLoop()
        {
            Room room = World.rooms[World.players[0].PlayerLocation];
            string action;
            action = Console.ReadLine().ToLower();
            do
            {
                room = World.rooms[World.players[0].PlayerLocation];
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
                    case "u":
                    case "up":
                    case "d":
                    case "down":
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
            Console.WriteLine("\nYou feel your body fade from reality, into the ash you've walked upon.");
            Console.WriteLine("Your body will be a warning to those to come.");
            Console.WriteLine("+++++Game Over+++++\nPress any key to continue..."); //2 writeLine statements in 1. leave it as is
            Console.ReadLine();
        }

        public static void NormalState(Player player)
        {
            //TODO - initial statement between loops, such as inital information whent the player arrives in a room
            Room room = World.rooms[World.players[0].PlayerLocation];
            Console.WriteLine($"You are currently in {room.Name}");
            Console.WriteLine($"{room.Description}");
            Console.WriteLine($"Current HP: {player.PlayerHP}");
            Console.WriteLine("Please enter a command: ");
            GameplayLoop();
        }

        public static void LookAround()
        {
            Room room = World.rooms[World.players[0].PlayerLocation];
            //display mods, items, etc.
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
        }
    }
}
