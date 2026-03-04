using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP5
{
    internal class IMAX: IBook, IPrint, ICloneTicket
    {
        private static int counter = 1;
        public int Id { get;  set; }
        public string MovieName { get; set; }
        public double Price { get; set; }
        public bool Is3D { get; set; }
        public bool IsBooked { get;  set; }
        public IMAX(string movie, double price, bool is3D)
        {
            Id = counter++;
            MovieName = movie;
            Price = price;
            Is3D = is3D;
        }
        public void Book()
        {
            if (!IsBooked)
            {
                IsBooked = true;
                Console.WriteLine($"IMAX Ticket {Id} for {MovieName} is booked.");
            }
            else
            {
                Console.WriteLine($"IMAX Ticket {Id} for {MovieName} is already booked.");
            }
        }
        public void cancel()
        {
            if (IsBooked)
            {
                IsBooked = false;
                Console.WriteLine($"IMAX Ticket {Id} for {MovieName} is canceled.");
            }
            else
            {
                Console.WriteLine($"IMAX Ticket {Id} for {MovieName} is not booked yet.");
            }
        }
        public void Print()
        {
            Console.WriteLine($"IMAX Ticket ID: {Id}, Movie: {MovieName}, Price: {Price}, 3D: {Is3D}, Booked: {IsBooked}");
        }
        public ICloneTicket Clone()
        {
            return new IMAX(MovieName, Price, Is3D);
        }
    }
    
    }
