using DesignPatterns.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Which vehicle you would travel? Please choose one");
            Console.WriteLine("1.Bus \n2.Train \n3.Plane");

            var ticketType = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter FromCity: ");
            var fromCity = Console.ReadLine();
            Console.Write("Please Enter ToCity: ");
            var toCity = Console.ReadLine();            

            if(ticketType == 1)
            {
                var ticket = new TicketFactory().getTicket(1);
                ticket.BuyTicket(DateTime.Now, fromCity,toCity);
            }
            else if(ticketType == 2)
            {
                var ticket = new TicketFactory().getTicket(2);
                ticket.BuyTicket(DateTime.Now, fromCity, toCity);
            }
            else if(ticketType == 3)
            {
                var ticket = new TicketFactory().getTicket(3);
                ticket.BuyTicket(DateTime.Now, fromCity, toCity);
            }

            Console.Read();
        }
    }
}
