namespace SRP
{
    public interface ILotteryGenerator
    {
         string Getname();

         void GenerateNumbers(string name);
    }
}