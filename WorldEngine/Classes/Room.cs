using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class Room
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
        private List<Potion> _potions;
        private List<Weapon> _weapons;
        private List<Monster> _monsters;
        private List<Treasure> _treasures;
        private List<Item> _items;

        public Room(int idNumber, string name, string description, int exitNorth, int exitSouth, int exitEast, int exitWest, int exitUp, int exitDown, List<Potion> potions, List<Weapon> weapons, List<Monster> monsters, List<Treasure> treasures, List<Item> items)
        {
            IdNumber = idNumber;
            Name = name;
            Description = description;
            ExitNorth = exitNorth;
            ExitSouth = exitSouth;
            ExitEast = exitEast;
            ExitWest = exitWest;
            ExitUp = exitUp;
            ExitDown = exitDown;
            Potions = potions;
            Weapons = weapons;
            Monsters = monsters;
            Treasures = treasures;
            Items = items;

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
        public List<Potion> Potions { get { return _potions; } set { _potions = value; } }
        public List<Weapon> Weapons { get { return _weapons; } set { _weapons = value; } }
        public List<Monster> Monsters { get { return _monsters; } set { _monsters = value; } }
        public List<Treasure> Treasures { get { return _treasures; } set { _treasures = value; } }
        public List<Item> Items { get { return _items; } set { _items = value; } }

    }
}
