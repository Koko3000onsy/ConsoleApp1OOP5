using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP5
{
    internal class Cinema
    {
        private List<IPrint> tickets = new List<IPrint>();
        public void open() => Console.WriteLine("Cinema is now open!");
        public void close() => Console.WriteLine("Cinema is now closed!");
        public void addTicket(IPrint ticket)
        {
            tickets.Add(ticket);
            Console.WriteLine($"Ticket added: {ticket}");
        }
        public void printTickets()
        {
            Console.WriteLine("Printing all tickets:");
            foreach (var ticket in tickets)
            {
                ticket.Print();
            }
        }
    }
}
