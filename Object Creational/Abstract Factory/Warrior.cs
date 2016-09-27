using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Warrior
    {
        public string Name { get; set;}

        public AbstractWeapon Weapon { get; set; }

        public int HitPoints { get; set;}

        public Warrior() {
            HitPoints = 20;
        }

        public void TakeHit(AbstractEnemy enemy) {
            HitPoints = HitPoints - enemy.Damage;
            Console.WriteLine(string.Concat("You just got slapped sideways by a ",enemy.Name));
            Console.WriteLine(string.Concat("You took ",enemy.Damage," points of damage."));
            Console.WriteLine(string.Concat("You have ",HitPoints," hit points remaining"));
        }
    }
}
