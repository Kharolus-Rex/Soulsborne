using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{

    public class Treasures : Loot
    {


        public Treasures(int Id, string name, int value) : base(Id, name, value)
        {
            ID = Id;

            Name = name;

            Value = value;

        }


    }
}
    


