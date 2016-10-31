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
            lotto.GenerateNumbers(lotto.Getname());
        }
    }
}
