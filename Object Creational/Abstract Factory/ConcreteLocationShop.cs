using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ConcreteLocationShop : AbstractLocation
    {
        public ConcreteLocationShop()
        {
        }

        public override void Visit(Warrior warrior)
        {
            throw new NotImplementedException();
        }
    }
}
