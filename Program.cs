using System;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] numbers = {2, 3, 4, 5, 6, 7, 8};
            string[] names = {"Makena", "Sandra", "Opiyo"};
            double[] marks = {39.4,56.9,76.85};

            int mynumbers = numbers[5];
            Console.WriteLine(mynumbers);
            string mynames = names[2];
            Console.WriteLine(mynames);
            double mymarks = marks[2];
            Console.WriteLine(mymarks);

            Console.ReadKey();


        }
    }
}