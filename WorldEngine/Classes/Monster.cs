using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class Monster : LivingCreature
    {
        private string _description;
        private Weapon _monsterWeapon;

        public Monster(int Id, string name, string description, string race, int Hp, int Ac, Weapon monsterWeapon) : base(Hp, Ac, Id, race, name)
        {
            ID = Id;
            Name = name;
            Description = description;
            Race = race;
            HP = Hp;
            AC = Ac;
            MonsterWeapon = monsterWeapon;
        }

        
        public string Description { get { return _description;} set { _description = value; } }
        public Weapon MonsterWeapon { get { return _monsterWeapon; } set { _monsterWeapon = value; } }
    }
}
