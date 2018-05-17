using System.Linq;
using System.Collections.Generic;
using Lab.Game.FizzBuzz;
using Xunit;

namespace Lab.Game.FizzBuzzTest
{
    public class GameRuleNumberDivisibleByFiveTest
    {

        private GameRuleNumberDivisibleByFive _gameRuleNumberDivisibleByFive;

        public GameRuleNumberDivisibleByFiveTest()
        {
            _gameRuleNumberDivisibleByFive = new GameRuleNumberDivisibleByFive();
        }

        [Fact]
        public void IsDivisible_ShouldBe_False()
        {
            Assert.False(_gameRuleNumberDivisibleByFive.IsDivisible(2));
        }

        [Fact]
        public void IsDivisible_ShouldBe_True()
        {
            Assert.True(_gameRuleNumberDivisibleByFive.IsDivisible(5));
        }

        [Theory]
        [InlineData(2, false, "Buzz")]
        [InlineData(3, false, "Buzz")]
        [InlineData(6, false, "Buzz")]
        [InlineData(5, true, "Buzz")]
        [InlineData(10, true, "Buzz")]
        [InlineData(15, true, "Buzz")]
        public void Test_IsDivisible_And_Print(int number, bool IsDivisibleResult, string printResult)
        {
            Assert.Equal(IsDivisibleResult, _gameRuleNumberDivisibleByFive.IsDivisible(number));
            Assert.Equal(printResult, _gameRuleNumberDivisibleByFive.Print());
        }

        [Theory]
        [MemberData(nameof(DataMultiplesOfFive))]
        public void IsDivisible_ShouldBe_False_And_Print_ShouldBe_Fizz(int number, string print)
        {
            Assert.True(_gameRuleNumberDivisibleByFive.IsDivisible(number));
            Assert.Equal(print, _gameRuleNumberDivisibleByFive.Print());
        }
        public static IEnumerable<object[]> DataMultiplesOfFive() => Enumerable.Range(1, 100)
                                                                     .Where(n => n % 5 == 0 && n % 3 != 0)
                                                                     .Select(x => (new object[] { x, "Buzz" }));
    }
}
