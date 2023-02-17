using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyAdapter
{
    internal abstract class Client
    {
        public string Name { get; }
        public int Age { get; }
        public Client(string name, int age) 
        { 
            Name = name;
            Age = age;  
        }
        public virtual bool checkIsAdult()
        {
            return Age >= 18;
        }
    }
}
