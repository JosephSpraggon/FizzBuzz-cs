using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter A Number!");
            num = Convert.ToInt16(Console.ReadLine());
            if (num % 15 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }
}
