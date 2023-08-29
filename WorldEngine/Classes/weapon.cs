using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine.Classes
{
    internal class Weapon
    {
        private int _idNumber;
        private string _name;
        private string _description;
        private string _damage;
        private string _damageType;
        private int _price;
        public Weapon(int idNumber, string name, string damage, string damageType, int price, string description)
        {
            IdNumber = idNumber;

            Name = name;

            Description = description;

            Damage = damage;

            DamageType = damageType;

            Price = price;
        }

        public int IdNumber { get { return _idNumber; } set { _idNumber = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Damage { get { return _damage; } set { _damage = value; } }
        public string DamageType { get { return _damageType; } set { _damageType = value; } }
        public int Price { get { return _price; } set { _price = value; } }
        public string Description { get { return _description; } set { _description = value; } }
    }
}
