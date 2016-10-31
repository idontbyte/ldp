using System;
using System.Linq;

namespace SRP
{
    public class Lotto : ILotteryGenerator
    {
        public void GenerateNumbers(string name)
        {
            Console.WriteLine(string.Concat("Hello ",name," your LOTTO numbers are:"));
            
            // 6 numbers between 1 and 59
            var rnd = new Random();
            var numbers = new int[6];
            for (var i = 0; i <= 5; i++) {
                numbers[i] = rnd.Next(1,60);
            }
            Console.WriteLine(string.Join(",",numbers.OrderBy(n=>n)));
        }

        public string Getname()
        {
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }
    }
}