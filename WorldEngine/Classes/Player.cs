using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class Player : LivingCreature
    {
        private int _location;
        private List<Weapon> _weapons;
        private List<Items> _items;
        private List<Potion> _potion;
        private List<Treasures> _treasures;

        public Player(int Id, string name, string race, int location, int Hp, int Ac, List<Weapon> weapons, List<Items> items, List<Potion> potion, List<Treasures> treasures) : base(Hp, Ac, Id, race, name)
        {
            ID = Id;
            Name = name;
            Race = race;
            PlayerLocation = location;
            HP = Hp;
            AC = Ac;
            Weapons = weapons;
            Item = items;
            Potions = potion;
            Treasure = treasures;
        }
        public int PlayerLocation { get { return _location; } set { _location = value; } }
        public List<Weapon> Weapons { get { return _weapons; } set { _weapons = value; } }
        public List<Items> Item { get { return _items; } set { _items = value; } }
        public List<Potion> Potions { get { return _potion; } set { _potion = value; } }
        public List<Treasures> Treasure { get { return _treasures; } set { _treasures = value; } }
    }
}
