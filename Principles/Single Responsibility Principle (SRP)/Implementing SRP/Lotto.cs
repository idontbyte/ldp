using System;
using System.Linq;

namespace SRP
{
    public class Lotto : ILotteryGenerator
    {
        public string GenerateNumbers()
        {            
            // 6 numbers between 1 and 59
            var rnd = new Random();
            var numbers = new int[6];
            for (var i = 0; i <= 5; i++) {
                numbers[i] = rnd.Next(1,60);
            }
            return string.Join(",",numbers.OrderBy(n=>n));
        }
    }
}