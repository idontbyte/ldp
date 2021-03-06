using System;

namespace AbstractFactory
{
    public class Warrior
    {
        public string Name { get; set;}

        public AbstractWeapon Weapon { get; set; }

        public int HitPoints { get; set;}

        public int StrengthModifier { get; set; }

        public int AttackBonus { get; set; }

        public int ArmorClass { get; set; }

        public Warrior() {
            HitPoints = 20;
            StrengthModifier = 2;
            AttackBonus = 2;
            ArmorClass = 17;
        }

        public void TakeHit(AbstractEnemy enemy) {
            HitPoints = HitPoints - enemy.Damage;
            Console.WriteLine(string.Concat("You just got slapped sideways by a ",enemy.Name));
            Console.WriteLine(string.Concat("You took ",enemy.Damage," points of damage."));
            Console.WriteLine(string.Concat("You have ",HitPoints," hit points remaining"));
        }
    }
}
