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
            WorldLoad.LoadWeapons();
            WorldLoad.LoadMonsters();
            WorldLoad.LoadRooms();
            WorldLoad.LoadPlayer();
            WorldLoad.LoadItems();
            WorldLoad.LoadPotions();
            WorldLoad.LoadTreasures();


            //Gameplay loop to go below
            ActiveGameplay.GameStart();
            ActiveGameplay.NormalState(World.players[0]);
            ActiveGameplay.GameplayLoop();
            ActiveGameplay.ExitState();

        }
    }
}
