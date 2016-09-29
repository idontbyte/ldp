namespace AbstractFactory
{
    public class ConcreteEnemyLion : AbstractEnemy
    {


        public ConcreteEnemyLion()
        {
            HitPoints = 15;
        }

        public override int Damage
        {
            get
            {
                return 5;
            }
        }

        public override int HitPoints { get; set; }

        public override string Name
        {
            get
            {
                return "Lion";
            }
        }
    }
}
