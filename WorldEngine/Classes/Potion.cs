using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine

public class Class1
{
    private int _idNumber;
    private string _name;
    //private string _description;  |  Depricated for now
    private string _usage;
    public Potion(int idNumber, string name, string usage)
    {
        IdNumber = idNumber;

        Name = name;

        usage = usage;
    }

    public int IdNumber { get { return _idNumber; } set { _idNumber = value; } }
    public string Name { get { return _name; } set { _name = value; } }
    public string Usage { get { return _usage; } set { _usage = value; } }

}

}