using System;

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
