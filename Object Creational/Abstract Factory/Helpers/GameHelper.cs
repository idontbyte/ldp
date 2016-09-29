using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public static class GameHelper
    {
        public static void Pause() {
            System.Threading.Thread.Sleep(2000);
        }
    }
}
