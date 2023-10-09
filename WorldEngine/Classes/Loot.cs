using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class Loot
    {
        private int _ID;
        private string _Name;
        private int _Value;

        public Loot(int Id, string name, int value)
        {
            ID = Id;
            Name = name;
            Value = value;
        }
        public int ID { get { return _ID; } set { _ID = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
        public int Value { get { return _Value; } set { _Value = value; } }
    }

}

