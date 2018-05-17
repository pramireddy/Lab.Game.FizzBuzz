namespace Lab.Game.FizzBuzz
{
    public class GameRuleNumberDivisibleByThreeAndFive:IGameRule
    {
        public bool IsDivisible(int number) => number % 3 == 0 && number % 5 == 0;

        public string Print() => "FizzBuzz";
    }
}
