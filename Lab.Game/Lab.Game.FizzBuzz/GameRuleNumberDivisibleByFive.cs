namespace Lab.Game.FizzBuzz
{
    public class GameRuleNumberDivisibleByFive: IGameRule
    {
        public bool IsDivisible(int number) => number % 5 == 0;

        public string Print() => "Buzz";
    }
}
