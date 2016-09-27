using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ConcreteEnemyBear : AbstractEnemy
    {
        public ConcreteEnemyBear()
        {
        }

        public override int Damage
        {
            get
            {
                return 3;
            }
        }

        public override int HitPoints
        {
            get
            {
                return 20;
            }
        }

        public override string Name
        {
            get
            {
                return "Bear";
            }
        }
    }
}
