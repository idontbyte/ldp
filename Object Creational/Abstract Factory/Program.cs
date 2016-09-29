namespace AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Introduction.Welcome();
            var warrior = Introduction.NewWarrior();
            Introduction.ChooseWeapon(warrior);

            while (warrior.HitPoints > 0) {
                var destination = Travel.ChooseDestination();
                destination.Visit(warrior);
            }
        }
    }
}
