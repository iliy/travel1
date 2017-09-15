using AppCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        Program()
        {
            var travel = new Travelpayouts();
            string result = travel.getPrice();
            Console.Write(result);
            Console.ReadKey();
        }
    }
}
