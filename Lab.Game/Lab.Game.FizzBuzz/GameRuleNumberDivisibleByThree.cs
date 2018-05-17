namespace Lab.Game.FizzBuzz
{
    public class GameRuleNumberDivisibleByThree : IGameRule
    {
        public bool IsDivisible(int number) => number % 3 == 0;

        public string Print() => "Fizz";
    }
}
