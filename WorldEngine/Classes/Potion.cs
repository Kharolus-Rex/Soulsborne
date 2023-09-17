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
    private string action;
    public Potion(int idNumber, string name, string action)
    {
        IdNumber = idNumber;

        Name = name;

       
        
        
    }

    public int IdNumber { get { return _idNumber; } set { _idNumber = value; } }
    public string Name { get { return _name; } set { _name = value; } }
    
    
    

}

