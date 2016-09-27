using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AbstractWeapon
    {
        // damage per hit
        public abstract int Damage { get; }
        // hits per second
        public abstract double Speed { get; }
        public abstract string Name { get; }
    }
}
