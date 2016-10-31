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
    }
}
