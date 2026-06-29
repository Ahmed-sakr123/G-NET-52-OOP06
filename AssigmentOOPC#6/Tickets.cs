using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AssigmentOOPC_6
{
    public abstract class Ticket
    {
        private static int counter = 1;

        public int TicketId { get; }
        public string MovieName { get; set; }
        public double Price { get; set; }
        public bool IsBooked { get; protected set; }

        protected Ticket(string movieName, double price)
        {
            TicketId = counter++;
            MovieName = movieName;
            Price = price;
        }

        public abstract double CalculatePriceAfterTax();
     
        public bool Book()
        {
            if (IsBooked)
                return false;

            IsBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!IsBooked)
                return false;

            IsBooked = false;
            return true;
        }
        public virtual void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | Price: {Price} | " +
                $"Final: {CalculatePriceAfterTax():F2} | " +
                $"Booked: {(IsBooked ? "Yes" : "No")}");
        }
    }

}

