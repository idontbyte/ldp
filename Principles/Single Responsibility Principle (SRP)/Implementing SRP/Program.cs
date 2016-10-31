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
            var scInterface = new ScreenInterface();
            scInterface.Output("What is your name?");
            var userName = scInterface.Input();
            var lotto = new Lotto();
            var numbers = lotto.GenerateNumbers();
            scInterface.Output(string.Concat("Hello ",userName," your LOTTO numbers are:"));
            scInterface.Output(numbers);
        }
    }
}
