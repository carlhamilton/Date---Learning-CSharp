using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Name:");
            string name = Console.ReadLine();

            Console.WriteLine("How many hours of sleep did you get last night?");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            if(hoursOfSleep >= 8)
            {
                Console.WriteLine("You are well rested");
            }
            else
            {
                Console.WriteLine("You need more sleep");
            }

            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                Console.WriteLine("NOOOOO! We have to work tomorrow");
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("Another hard slog to come tomorrow!");
         
                Console.ReadKey();



            }
        }
    }
}
