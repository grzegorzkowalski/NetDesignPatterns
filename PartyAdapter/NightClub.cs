using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyAdapter
{

    internal class NightClub
    {     
        public void letsParty(Client client)
        {
            
            if (client.checkIsAdult())
            {
                Console.WriteLine("Let's party!");
            }
            else
            {
                Console.WriteLine("Do domu młody");
            }
        }
    }
}
