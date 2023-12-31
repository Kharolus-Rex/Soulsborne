﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class ActiveGameplay
    {
        //also for common messages the system may give the player

        public static string GetUserInput()
        {
            string input;
            input = Console.ReadLine();
            return input;
        }
        public static void CommandCase() 
        {
            string input = GetUserInput();
            string[] commands = input.Split(null);
            string action = commands[0].ToLower();
            string noun;
            if (commands.Length != 1)
            {
                noun = commands[1];
            }
            else
            {
                noun = "";
            }
            GameplayLoop(action, noun);
        }
        public static void GameStart()
        {
            Console.WriteLine("Welcome to Soulsborne");
        }

        public static void GameplayLoop(string action, string noun)
        {
            Room room = World.FindRoomByID(World.players[0].PlayerLocation);
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
                    case "u":
                    case "up":
                    case "d":
                    case "down":
                        Exploration.Movement(action, room);
                        break;
                    case "attack":
                        WorkingCombat.CombatLoop();
                        break;
                    //TODO Add a inventory command also need to update playercsv to have an inventory
                    case "look":
                        if (noun != "")
                        {
                            Exploration.LookAround(noun);
                        }
                        else
                        {
                            Exploration.LookAround();
                        }                     
                        break;
                    default:
                        Console.WriteLine("Your body and mind are not sync. You cannot do that action");
                        break;
                }

                NormalState(World.players[0]);

                CommandCase();

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
            Room room = World.FindRoomByID(World.players[0].PlayerLocation);
            Console.WriteLine($"You are currently in {room.Name}");
            Console.WriteLine($"{room.Description}");
            Console.WriteLine($"Current HP: {player.HP}");
            Console.WriteLine("Please enter a command: ");
        }

       
    }
}
