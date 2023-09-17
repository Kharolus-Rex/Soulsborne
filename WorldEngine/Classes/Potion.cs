using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine { 
}

public class Potion
{
    private int _idNumber;
    private string _name;
    private string _description;
    private int _value;
    

   

    public Potion(int idNumber, string name, string description, int value)
    {
        IdNumber = idNumber;

        Name = name;

        Description = description;

        Value = value;

    }
    public int IdNumber { get { return _idNumber; } set { _idNumber = value; } }
    public string Name { get { return _name; } set { _name = value; } }
    public string Description { get { return _description; } set { _description = value; } }
    public int Value { get { return _value; } set { _value = value; } }
    
    

}

