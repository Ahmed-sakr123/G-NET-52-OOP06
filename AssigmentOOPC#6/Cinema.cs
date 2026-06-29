using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace AssigmentOOPC_6
{
    public partial class Cinema
    {
        private List<Ticket> tickets = new List<Ticket>();

        public void Open()
        {
            Console.WriteLine("=== Cinema Opened ===");
            Console.WriteLine("Projector ON");
        }

        public void Close()
        {
            Console.WriteLine("Projector OFF");
            Console.WriteLine("=== Cinema Closed ===");
        }

        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        public void BookTicket(Ticket ticket)
        {
            ticket.Book();
        }
    }
}

