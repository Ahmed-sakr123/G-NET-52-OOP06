using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentOOPC_6
{
    public class ImaxTicket : Ticket
    {
        public bool Is3D { get; set; }

        public ImaxTicket(string movieName,
                            double price,
                            bool is3D)
              : base(movieName, price)
        {
            Is3D = is3D;
        }

        public override double CalculatePriceAfterTax()
        {
            return Price * 1.14;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | IMAX | " +
                $"3D: {(Is3D ? "Yes" : "No")} | " +
                $"Price: {Price} | " +
                $"Final: {CalculatePriceAfterTax():F2} | " +
                $"Booked: {(IsBooked ? "Yes" : "No")}");
        }
    }
}

