using System;
using System.Linq;

namespace AbstractFactory
{
    public static class Introduction
    {
        public static void Welcome() {
            Console.WriteLine("Welcome to the abstract factory demo.");
            GameHelper.Pause();
            Console.WriteLine("For the purposes of this demo, imagine you are a warrior, profficient in many weapons");
            GameHelper.Pause();
            Console.WriteLine("Let us begin.");
        }

        public static Warrior NewWarrior() {
            Console.WriteLine("Welcome player, what is your name?");
            var name = Console.ReadLine();
            var warrior = new Warrior() {
                Name = name
            };
            return warrior;
        }

        public static void ChooseWeapon(Warrior warrior) {
            Console.WriteLine(string.Concat("Hello ", warrior.Name, ", would you care to choose a weapon?"));
            GameHelper.Pause();
            Console.WriteLine("");
            Console.WriteLine("Choose a weapon, 'Sword', 'Axe' or 'Dagger'");

            // request the user selects a weapon
            var weaponInput = string.Empty;
            weaponInput = Console.ReadLine();
            while (new [] { "Sword", "Axe", "Dagger" }.All(v => v != weaponInput)) {
                Console.WriteLine(string.Concat(weaponInput, " is not an option, please choose 'Sword', 'Axe' or 'Dagger'"));
                weaponInput = Console.ReadLine();
            }
            Console.WriteLine(string.Concat("You chose: ",weaponInput));
            
            // use reflection to find the weapon using the type entered
            var weaponType = string.Concat("AbstractFactory.ConcreteWeapon",weaponInput);
            Type t = Type.GetType(weaponType);
            if (t == null) {
                throw new Exception("Type " + weaponType + " not found.");
            }
            var weapon = (AbstractWeapon)Activator.CreateInstance(t);
            
            GameHelper.Pause();

            Console.WriteLine(string.Concat("Good choice, your "
                ,weapon.Name," has ",weapon.Damage," damage."));

            warrior.Weapon = weapon;
        }
    }
}
