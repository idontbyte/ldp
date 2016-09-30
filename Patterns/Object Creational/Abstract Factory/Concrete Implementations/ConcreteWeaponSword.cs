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
    }
}
