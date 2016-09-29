using System;

namespace AbstractFactory
{
    public static class Dice
    {
        public static int RollD20() {
            var rand = new Random();
            return rand.Next(20);
        }
    }
}
