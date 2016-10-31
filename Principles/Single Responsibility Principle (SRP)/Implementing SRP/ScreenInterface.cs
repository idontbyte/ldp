using System;

namespace SRP
{
    public class ScreenInterface : IInputOutput
    {
        public string Input()
        {
            return Console.ReadLine();
        }

        public void Output(string outPut)
        {
            Console.WriteLine(outPut);
        }
    }
}