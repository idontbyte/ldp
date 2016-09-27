using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ConcreteWeaponDagger : AbstractWeapon
    {
        public ConcreteWeaponDagger()
        {
        }

        public override int Damage
        {
            get
            {
                return 2;
            }
        }

        public override string Name
        {
            get
            {
                return "Dagger";
            }
        }

        public override double Speed
        {
            get
            {
                return 2;
            }
        }
    }
}
