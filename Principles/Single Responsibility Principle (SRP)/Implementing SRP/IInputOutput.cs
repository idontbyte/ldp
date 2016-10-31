namespace SRP
{
    // the new user input interface has only one reason to change
    // and implements SRP
    public interface IInputOutput
    {
         string Input();

         void Output(string outPut);
    }
}