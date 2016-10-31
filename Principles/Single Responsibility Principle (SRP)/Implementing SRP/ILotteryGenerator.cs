namespace SRP
{
    // the lottery generator interface now only has one reason to change
    // user input & ouput is now handled by the input/output interface and
    // we have implemented a screen interface to capture input and print output
    // using the terminal
    public interface ILotteryGenerator
    {
         string GenerateNumbers();
    }
}