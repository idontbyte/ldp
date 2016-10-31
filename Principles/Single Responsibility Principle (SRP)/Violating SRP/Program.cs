using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // lottery number generator
            var lotto = new Lotto();
            var name = lotto.Getname();
            var numbers =lotto.GenerateNumbers(name);
            lotto.PrintNumbers(numbers);
        }
    }
}
