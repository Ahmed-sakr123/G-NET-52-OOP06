using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentOOPC_6
{
    public class StandardTicket : Ticket
    {
        private string v;

        public StandardTicket(string movieName, double price)
            : base(movieName, price)
        {
        }

        public StandardTicket(string movieName, double price, string v) : this(movieName, price)
        {
            this.v = v;
        }

        public override double CalculatePriceAfterTax()
        {
            return Price * 1.14;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | Standard | " +
                $"Price: {Price} | Final: {CalculatePriceAfterTax():F2} | " +
                $"Booked: {(IsBooked ? "Yes" : "No")}");
        }
    }

}

