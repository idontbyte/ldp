using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public static class Travel
    {
        public static AbstractLocation ChooseDestination() {
            Console.WriteLine("Where would you like to go? Please choose 'Woods' or 'Shop'");
            var destinationInput = string.Empty;
            destinationInput = Console.ReadLine();
            while (new [] { "Woods", "Shop" }.All(v => v != destinationInput)) {
                Console.WriteLine(string.Concat(destinationInput, " is not an option, please choose 'Woods' or 'Shop'"));
                destinationInput = Console.ReadLine();
            }
            Console.WriteLine(string.Concat("You chose: ",destinationInput));

            // use reflection to find the location using the text entered
            var locationType = string.Concat("AbstractFactory.ConcreteLocation",destinationInput);
            Type t = Type.GetType(locationType);
            if (t == null) {
                throw new Exception("Type " + locationType + " not found.");
            }
            var location = (AbstractLocation)Activator.CreateInstance(t);
            return location;
        }
    }
}
