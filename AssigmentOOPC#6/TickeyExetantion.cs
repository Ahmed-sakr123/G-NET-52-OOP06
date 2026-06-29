using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentOOPC_6
{
    public static class TicketExtensions
    {
        public static string GetReceipt(this Ticket ticket)
        {
            return
        $@"========== RECEIPT ==========
        Movie    : {ticket.MovieName}
        Type     : {ticket.GetType().Name}
        Price    : {ticket.Price}
        Final    : {ticket.CalculatePriceAfterTax()}
        Status   : {(ticket.IsBooked ? "Booked" : "Not Booked")}
        =============================";
        }

        public static double TotalRevenue(this Ticket[] tickets)
        {
            double total = 0;

            foreach (Ticket t in tickets)
            {
                total += t.CalculatePriceAfterTax();
            }
            Console.WriteLine(" --- Extension Method: Total Revenue ---");
            return total;
        }

    }
}
