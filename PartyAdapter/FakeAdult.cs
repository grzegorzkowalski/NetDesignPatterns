using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyAdapter
{
    internal class FakeAdult : Teenager
    {
        public FakeAdult(string name, int age) : base(name, age)
        {
        }

        public override bool checkIsAdult()
        {
            return true;
        }
    }
}
