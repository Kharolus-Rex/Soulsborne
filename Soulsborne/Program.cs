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
            ActiveGameplay.GameStart();

            //Gameplay loop to go below
            ActiveGameplay.GameplayLoop();
            ActiveGameplay.ExitState();
        }
    }
}
