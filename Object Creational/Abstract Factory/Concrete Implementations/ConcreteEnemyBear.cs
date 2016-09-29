namespace AbstractFactory
{
    public class ConcreteEnemyBear : AbstractEnemy
    {
        public ConcreteEnemyBear()
        {
            HitPoints = 20;
        }

        public override int Damage
        {
            get
            {
                return 3;
            }
        }

        public override int HitPoints{ get; set; }
        

        public override string Name
        {
            get
            {
                return "Bear";
            }
        }
    }
}
