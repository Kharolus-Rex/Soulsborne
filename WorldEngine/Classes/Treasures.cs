using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  namespace WorldEngine { }

public class Treasures
{

    private int _idNumber;
    private string _name;
    private int _value;
    private string value;

    public Treasures(int idNumber, string name)
    {
        IdNumber = idNumber;

        Name = name;

        Value = Value;

    }

    public Treasures(int idNumber, string name, string value) : this(idNumber, name)
    {
        this.value = value;
    }

    public int IdNumber { get { return _idNumber; } set { _idNumber = value; } }
    public string Name { get { return _name; } set { _name = value; } }

    private int Value { get { return _value; } set { _value = value; } }

   }
    


