namespace SRP
{
    // The lottery generator interface violates SRP because
    // it has multiple reasons that it can change for example, 
    // if we implement 5 different lottery game generators
    // and then we want to change the 'get name' and 'print numbers'
    // functions we will also need to modify the get name function in 
    // all generators
    public interface ILotteryGenerator
    {
         string Getname();

         string GenerateNumbers(string name);

         void PrintNumbers(string numbers);
    }
}