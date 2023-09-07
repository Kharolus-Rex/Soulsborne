using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine.Classes
{
    internal class Monster
    {
        private int _idNumber;
        private string _name;
        private string _description;
        private string _race;
        private int _HP;
        private int _AC;
        private Weapon _monsterWeapon;

        public Monster(int idNumber, string name, string description, string race, int hP, int aC, Weapon monsterWeapon)
        {
            IdNumber = idNumber;
            Name = name;
            Description = description;
            Race = race;
            HP = hP;
            AC = aC;
            MonsterWeapon = monsterWeapon;
        }

        public int IdNumber { get { return _idNumber; } set { _idNumber = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description;} set { _description = value; } }
        public string Race { get { return _race;} set { _race = value; } }
        public int HP { get { return _HP; } set { _HP = value; } }
        public int AC { get { return _AC; } set { _AC = value; } }
        public Weapon MonsterWeapon { get { return _monsterWeapon; } set { _monsterWeapon = value; } }
    }
}
