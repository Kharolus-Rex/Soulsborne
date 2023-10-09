using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{


    public class Potion : Loot
    {
        private string _description;




        public Potion(int Id, string name, string description, int value) : base(Id, name, value)
        {
            ID = Id;

            Name = name;

            Description = description;

            Value = value;

        }
        public string Description { get { return _description; } set { _description = value; } }


    }
}

