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

        public Warrior()
        {
            
        }
    }
}
