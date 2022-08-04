using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Joel";
            int age = 24;
            char grade = 'A';
            bool cat = true;
            double price = 14.99D;
            decimal usaGDP = 20939999999.99M;

            Console.WriteLine($"My name is {firstName}. I am {age} years old.");
            Console.WriteLine($"When I was in school, I was told to get {grade} on my report card.");
            Console.WriteLine($"Currently it is: {cat} that I have a cat.");
            Console.WriteLine($"My grocery bill last week was ${price}. This week it was ${usaGDP}. Inflation is crazy.");
        }
    }
}
