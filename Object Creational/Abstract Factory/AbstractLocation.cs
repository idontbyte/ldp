using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AbstractLocation
    {
        public abstract void Visit(Warrior warrior);
    }
}
