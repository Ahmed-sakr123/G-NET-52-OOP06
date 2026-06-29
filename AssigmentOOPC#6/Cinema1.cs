using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentOOPC_6

{
    

    public partial class Cinema
    {
    
        public void PrintAllTickets()
        {
            Console.WriteLine("\n--- All Tickets (from Cinema.Reporting) ---");

            foreach (Ticket ticket in tickets)
            {
                ticket.Print();
            }
        }

        public void ShowStatistics()
        {
            Console.WriteLine($"\nTotal Tickets: {tickets.Count}");
        }
    }
}
