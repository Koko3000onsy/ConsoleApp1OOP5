using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP5
{
    internal class VIP: IBook, IPrint, ICloneTicket
    {
        private static int counter = 1;
        public int Id { get;  set; }
        public string MovieName { get; set; }
        public double Price { get; set; }
        public bool LoungeAccess { get; set; }
        public double Fee { get; set; }
        public bool IsBooked { get;  set; }

        public VIP(string movie, double price, bool loungeAccess, double fee)
        {
            Id = counter++;
            MovieName = movie;
            Price = price;
            LoungeAccess = loungeAccess;
            Fee = fee;
        }
        public void Book()
            {
                if (!IsBooked)
                {
                    IsBooked = true;
                    Console.WriteLine($"VIP Ticket {Id} for {MovieName} is booked.");
                }
                else
                {
                    Console.WriteLine($"VIP Ticket {Id} for {MovieName} is already booked.");
                }
        }
        public void cancel()
        {
            if (IsBooked)
            {
                IsBooked = false;
                Console.WriteLine($"VIP Ticket {Id} for {MovieName} is canceled.");
            }
            else
            {
                Console.WriteLine($"VIP Ticket {Id} for {MovieName} is not booked yet.");
            }
        }
        public void Print()
        {
            Console.WriteLine($"VIP Ticket ID: {Id}, Movie: {MovieName}, Price: {Price}, Lounge Access: {LoungeAccess}, Fee: {Fee}, Booked: {IsBooked}");
        }
        public ICloneTicket Clone()
        {
            return new VIP(MovieName, Price, LoungeAccess, Fee);
        }
    }
}
