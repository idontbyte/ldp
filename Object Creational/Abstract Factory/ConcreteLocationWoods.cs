using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ConcreteLocationWoods : AbstractLocation
    {
        public ConcreteLocationWoods()
        {
        }

        private Warrior _warrior;

        public override void Visit(Warrior warrior)
        {
            _warrior = warrior;

            Console.WriteLine("Would you like to 'Hunt' or 'Travel'?");
            var destinationInput = string.Empty;
            destinationInput = Console.ReadLine();
            while (new [] { "Hunt", "Travel" }.All(v => v != destinationInput)) {
                Console.WriteLine(string.Concat(destinationInput, " is not an option, please choose 'Hunt' or 'Travel'"));
                destinationInput = Console.ReadLine();
            }
            Console.WriteLine(string.Concat("You chose: ",destinationInput));
            if (destinationInput == "Hunt") {
                Hunt();
            }
        }

        private void Hunt() {
            // get all concrete classes of type abstract enemy
            var enemies = Helpers.GetEnumerableOfType<AbstractEnemy>(null);
            foreach (var enemy in enemies) {
                Console.WriteLine(enemy.Name);
            }
        }
    }
}
