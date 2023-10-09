using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class LivingCreature
    {
        private int _HP;
        private int _AC;
        private int _ID;
        private string _Race;
        private string _Name;
        public LivingCreature(int Hp, int Ac, int Id, string race, string name)
        {
            HP = Hp;
            AC = Ac;
            ID = Id;
            Race = race;
            Name = name;
        }
        public int HP { get { return _HP; } set { _HP = value; } }
        public int AC { get { return _AC; } set { _AC = value; } }
        public int ID { get { return _ID; } set { _ID = value; } }
        public string Race { get { return _Race; } set { _Race = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
    }

}
