using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.FactoryMethod;

namespace DesignPatterns.FactoryMethod
{
    public class TicketFactory
    {
        public Ticket getTicket(int ticketType)
        {
            if(ticketType == 1)
            {
                return new Bus();
            }
            else if(ticketType == 2)
            {
                return new Train();
            }
            else if(ticketType == 3)
            {
                return new Fligth();
            }

            return null;
        }
    }
}
