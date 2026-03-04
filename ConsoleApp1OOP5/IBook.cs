using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP5
{
    internal interface IBook
    {
        void Book();
        void cancel();
        bool IsBooked { get; }
    }
}
