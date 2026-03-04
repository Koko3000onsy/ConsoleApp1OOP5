using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP5
{
    internal class BookingHelper
    {
        public void PrintAll(IPrint[] tickets)
        {
            Console.WriteLine("Booking helper. All tickets:");
            foreach (var ticket in tickets)
            {
                ticket.Print();
            }
        }
    }
}
