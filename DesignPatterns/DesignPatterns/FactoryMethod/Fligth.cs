using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class Fligth : Ticket
    {
        public override void BuyTicket(DateTime TicketDate, string FromCity, string ToCity)
        {
            Console.WriteLine("Flight Ticket Info:\n Date: " + TicketDate + "\n" + " FromCity: " + FromCity + "\n" + " ToCity: " + ToCity);
        }
    }
}
