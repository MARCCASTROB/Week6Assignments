using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class Person
    {
        private int _age;
        private string _name;

       public string Name
        {
            get { return _name; }
            set { _name = value; } 
        }

        public int Age 
        {
            get { return _age; } 
            set { _age = value; } 
        }

        public Person(string name, int age)
        {
            Name = name; 
            Age = age;
        }
    }
}
