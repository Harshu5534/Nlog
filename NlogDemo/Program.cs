using NlogDemo;
using System;
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Program");
            AddNumber number = new AddNumber();
            number.Sum(1, 2);
        }
    }
}