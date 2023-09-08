using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldEngine;

namespace Soulsborne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Load statements for lists
            WorldLoad.LoadWeapons();
            WorldLoad.LoadMonsters();
            WorldLoad.LoadRooms();
            WorldLoad.LoadPlayer();

            //Gameplay loop to go below
        }
    }
}
