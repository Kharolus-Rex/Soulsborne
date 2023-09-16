using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class Items
    {
        private int _idNumber;
        private string _name;
        private string _description;
        public Items(int idNumber, string name, string description)
        {
            IdNumber = idNumber;

            Name = name;

            Description = description;

            
        }

        public int IdNumber { get { return _idNumber; } set { _idNumber = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }

    }
}
