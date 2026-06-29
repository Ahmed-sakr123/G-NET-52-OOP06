using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentOOPC_6
{
    public class VipTicket:Ticket
    {
       
        public bool LoungeAccess { get; set; }
        public double VipFee { get; set; }


        public VipTicket(string movieName,
                         double price,
                         bool loungeAccess,
                         double vipFee)
            : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
            VipFee = vipFee;
        }

        public override double CalculatePriceAfterTax()
        {
            return (Price + VipFee) * 1.14;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | VIP | " +
                $"Lounge: {(LoungeAccess ? "Yes" : "No")} | " +
                $"Fee: {VipFee} | Price: {Price} | " +
                $"After Tax: {CalculatePriceAfterTax()} | " +
                $"Booked: {(IsBooked ? "Yes" : "No")}");
        }

    }
}
