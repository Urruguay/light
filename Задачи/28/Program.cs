using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {
            Tour tours = new Tour();
            tours.TourCalc();

            tours.TourCalc("Турция");

            tours.TourCalc("Красное море", 4);

            Console.Read();
        }
    }
}
