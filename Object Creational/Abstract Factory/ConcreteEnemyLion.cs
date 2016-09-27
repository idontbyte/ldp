using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ConcreteEnemyLion : AbstractEnemy
    {
        public ConcreteEnemyLion()
        {
        }

        public override int Damage
        {
            get
            {
                return 5;
            }
        }

        public override int HitPoints
        {
            get
            {
                return 15;
            }
        }

        public override string Name
        {
            get
            {
                return "Lion";
            }
        }
    }
}
