using System;

namespace AbstractFactory
{
    public abstract class AbstractEnemy
    {
        public abstract string Name { get; }
        public abstract int HitPoints { get; set; }
        public abstract int Damage { get; }

        public abstract int ArmorClass { get; }

        public void TakeHit(Warrior warrior) {
            HitPoints = HitPoints - warrior.Weapon.Damage;
            Console.WriteLine(string.Concat("You smash your ", warrior.Weapon.Name, " into the ", Name, "'s skull"));
            Console.WriteLine(string.Concat("It took ",warrior.Weapon.Damage," points of damage."));
            Console.WriteLine(string.Concat("It has ",HitPoints," hit points remaining"));
        }
    }
}
