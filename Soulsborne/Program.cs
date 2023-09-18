/**
* 9/16/23
* CSC 253
* Group 2
* Group Members: Connor, David, Ramon
* This group project is a simple text-based adventure game.
* The player will be able to explore, look around, move throughout the location
* and interact in a limited way with the world around them.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldEngine;

namespace Soulsborne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load statements for lists
            WorldLoad.LoadItems();
            WorldLoad.LoadPotions();
            WorldLoad.LoadTreasures();
            WorldLoad.LoadWeapons();
            WorldLoad.LoadMonsters();
            WorldLoad.LoadRooms();
            WorldLoad.LoadPlayer();
            

            //Gameplay loop to go below
            ActiveGameplay.GameStart();
            ActiveGameplay.NormalState(World.players[0]);
            ActiveGameplay.GameplayLoop();
            ActiveGameplay.ExitState();

        }
    }
}
