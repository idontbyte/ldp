using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ConcreteWeaponSword : AbstractWeapon
    {
        public ConcreteWeaponSword()
        {
        }

        public override int Damage
        {
            get
            {
                return 4;
            }
        }

        public override string Name
        {
            get
            {
                return "Sword";
            }
        }

        public override double Speed
        {
            get
            {
                return 0.9;
            }
        }
    }
}
