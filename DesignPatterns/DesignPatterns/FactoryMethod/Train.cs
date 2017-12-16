using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class Train : Ticket
    {
        public override void BuyTicket(DateTime TicketDate, string FromCity, string ToCity)
        {
            Console.WriteLine("Train Ticket Info:\n Date: " + TicketDate + "\n" + " FromCity: " + FromCity + "\n" + " ToCity: " + ToCity);
        }
    }
}
