using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine.Classes
{
    class Room
    {
        private int _idNumber;
        private string _name;
        private string _description;
        private int _exitNorth;
        private int _exitSouth;
        private int _exitEast;
        private int _exitWest;
        private int _exitUp;
        private int _exitDown;

        public Room(int IdNumber, string Name, string Description, int ExitNorth, int ExitSouth, int ExitEast, int ExitWest, int ExitUp, int ExitDown)
        {
            IdNumber = _idNumber;
            Name = _name;
            Description = _description;
            ExitNorth = _exitNorth;
            ExitSouth = _exitSouth;
            ExitEast = _exitEast;
            ExitWest = _exitWest;
            ExitUp = _exitUp;
            ExitDown = _exitDown;
        }
        public int IdNumber { get { return _idNumber;} set { _idNumber = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int ExitNorth { get { return _exitNorth; } set { _exitNorth = value; } }
        public int ExitSouth { get { return _exitSouth; } set { _exitSouth = value; } }
        public int ExitEast { get { return _exitEast; } set { _exitEast = value; } }
        public int ExitWest { get { return _exitWest; } set { _exitWest = value; } }
        public int ExitUp { get { return _exitUp; } set { _exitUp = value; } }
        public int ExitDown { get { return _exitDown; } set { _exitDown = value; } }

    }
}
