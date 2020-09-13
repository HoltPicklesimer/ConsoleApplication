using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, state, todayString;
            DateTime today, christmasDay;
            int daysTilChristmas;

            // Display my name and state
            name = "Ethan Picklesimer";
            state = "Ohio";

            Console.WriteLine($"My name is {name}.");
            Console.WriteLine($"I am from {state}.");

            // Display today's date with no time
            today = DateTime.Today;
            todayString = today.ToString("d");

            Console.WriteLine($"The current date is {todayString}.");

            // Display the number of days until Christmas this year
            christmasDay = new DateTime(today.Year, 12, 25);
            daysTilChristmas = (christmasDay - today).Days;

            Console.WriteLine("The number of days until Christmas" +
                $" this year is {daysTilChristmas} days.");

            // Programming example from 2.1
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Enter the width of the window in meters: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Enter the height of the window in meters: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square meters");

            // Prevent the Console from closing in Debug mode
            Console.ReadKey();
        }
    }
}
