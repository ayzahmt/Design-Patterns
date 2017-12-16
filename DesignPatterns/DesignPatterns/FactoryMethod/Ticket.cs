﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public abstract class Ticket
    {
        public abstract void BuyTicket(DateTime TicketDate, string FromCity, string ToCity);
    }
}
