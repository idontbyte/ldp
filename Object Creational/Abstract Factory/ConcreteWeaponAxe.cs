using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ConcreteWeaponAxe : AbstractWeapon
    {
        public ConcreteWeaponAxe()
        {
        }

        public override int Damage
        {
            get
            {
                return 6;
            }
        }

        public override string Name
        {
            get
            {
                return "Axe";
            }
        }

        public override double Speed
        {
            get
            {
                return 0.5;
            }
        }
    }
}
