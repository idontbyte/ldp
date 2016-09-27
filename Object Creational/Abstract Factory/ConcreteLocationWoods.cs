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
            Console.WriteLine("Dense woodlands lay before you, this could be a good place to hunt.");
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
            var rand = new Random();
            var enemy = enemies.ToList()[rand.Next(enemies.Count())];

            Console.WriteLine(
                string.Concat("You move in to the woods, as the light of the day falls away behind you hear a low growl, as you turn towards it you catch the predatory gaze of a ", 
                    enemy.Name, 
                    " who is approaching you at great speed."));

            while (enemy.HitPoints > 0 && _warrior.HitPoints > 0) {
                System.Threading.Thread.Sleep(1500);
                _warrior.TakeHit(enemy);
                System.Threading.Thread.Sleep(1500);
                enemy.TakeHit(_warrior);
            }
        }
    }
}
