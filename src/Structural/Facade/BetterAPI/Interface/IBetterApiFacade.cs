namespace DesignPatterns.Structural.Facade.BetterAPI.Interface
{
    public interface IBetterApiFacade
    {
        int AddThenMultiply(int addend1, int factor);

        int AddThenMultiply(int addend1, int addend2, int factor);

        int AddThenMultiply(int addend1, int addend2, int addend3, int factor);

        int AddThreeNumbers(int firstParam, int secondParam, int thirdParam);
    }
}
