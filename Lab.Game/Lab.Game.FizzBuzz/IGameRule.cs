namespace Lab.Game.FizzBuzz
{
    public interface IGameRule
    {
        bool IsDivisible(int number);
        string Print();
    }
}
