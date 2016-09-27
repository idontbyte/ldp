using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AbstractEnemy
    {
        public abstract string Name { get; }
        public abstract int HitPoints { get; }
        public abstract int Damage { get; }
    }
}
