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
    }
}
