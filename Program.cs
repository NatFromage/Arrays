using System;
using System.Collections;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Arrays");

            int[] numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers.Length);

            // Using the .Append() and .Prepend() methods and converting it back to a string array
            numbers = numbers.Append<int>(10).ToArray();
            numbers = numbers.Prepend<int>(0).ToArray();

            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write($"{numbers[x]}, ");
            }

            Console.WriteLine("\nWorking with string array");

            string[] dayArray = new string[] { "Mon", "Tue" };
            dayArray = dayArray.Append("Wed").ToArray();

            // Display values
            foreach (var item in dayArray)
            {
                Console.Write(item + " , ");
            }

            Console.WriteLine("\nWorking with objects");

            object[] obj = new[] { "12", "2.5", "8", "monday", "tuesday" };
            foreach (var item in obj)
            {
                Console.Write(item + " , ");
            }

            Console.ReadLine();
        }
    }
}
