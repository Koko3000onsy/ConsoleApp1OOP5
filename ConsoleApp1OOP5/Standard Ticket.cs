using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP5
{
    internal class Standard_Ticket :IBook, IPrint, ICloneTicket
    {
        private static int Counter = 1;
        public int Id { get;  set; }
        public string MovieName { get; set; }
        public string Seat { get; set; }
        public double Price { get; set; }
        public bool IsBooked { get;  set; }
         public Standard_Ticket(string movie, string seat, double price)
        {
            Id= Counter++;
            MovieName = movie;
            Seat = seat;
            Price = price;
        }
        public void Book()
        {
            if (!IsBooked)
            {
                IsBooked = true;
                Console.WriteLine($"Ticket {Id} for {MovieName} at seat {Seat} is booked.");
            }
            else
            {
                Console.WriteLine($"Ticket {Id} for {MovieName} at seat {Seat} is already booked.");
            }
        }
        public void cancel()
        {
            if (IsBooked)
            {
                IsBooked = false;
                Console.WriteLine($"Ticket {Id} for {MovieName} at seat {Seat} is canceled.");
            }
            else
            {
                Console.WriteLine($"Ticket {Id} for {MovieName} at seat {Seat} is not booked yet.");
            }
        }
        public void Print()
        {
            Console.WriteLine($"Ticket ID: {Id}, Movie: {MovieName}, Seat: {Seat}, Price: {Price}, Booked: {IsBooked}");
        }
        public ICloneTicket Clone()
        {
            return new Standard_Ticket(MovieName, Seat, Price);
        }
    }
}
