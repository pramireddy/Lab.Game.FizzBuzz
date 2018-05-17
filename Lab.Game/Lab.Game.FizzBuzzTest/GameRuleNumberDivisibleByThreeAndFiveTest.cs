using System.Linq;
using System.Collections.Generic;
using Lab.Game.FizzBuzz;
using Xunit;

namespace Lab.Game.FizzBuzzTest
{
    public class GameRuleNumberDivisibleByThreeAndFiveTest
    {
        private GameRuleNumberDivisibleByThreeAndFive _gameRuleNumberDivisibleByThreeAndFive;

        public GameRuleNumberDivisibleByThreeAndFiveTest()
        {
            _gameRuleNumberDivisibleByThreeAndFive = new GameRuleNumberDivisibleByThreeAndFive();
        }

        [Fact]
        public void IsDivisible_ShouldBe_False()
        {
            Assert.False(_gameRuleNumberDivisibleByThreeAndFive.IsDivisible(2));
        }

        [Fact]
        public void IsDivisible_ShouldBe_True()
        {
            Assert.True(_gameRuleNumberDivisibleByThreeAndFive.IsDivisible(15));
        }

        [Theory]
        [InlineData(2, false, "FizzBuzz")]
        [InlineData(3, false, "FizzBuzz")]
        [InlineData(6, false, "FizzBuzz")]
        [InlineData(5, false, "FizzBuzz")]
        [InlineData(10, false, "FizzBuzz")]
        [InlineData(15, true, "FizzBuzz")]
        [InlineData(30, true, "FizzBuzz")]
        public void Test_IsDivisible_And_Print(int number, bool IsDivisibleResult, string printResult)
        {
            Assert.Equal(IsDivisibleResult, _gameRuleNumberDivisibleByThreeAndFive.IsDivisible(number));
            Assert.Equal(printResult, _gameRuleNumberDivisibleByThreeAndFive.Print());
        }

        [Theory]
        [MemberData(nameof(DataMultiplesOfThreeAndFive))]
        public void IsDivisible_ShouldBe_False_And_Print_ShouldBe_Fizz(int number, string print)
        {
            Assert.True(_gameRuleNumberDivisibleByThreeAndFive.IsDivisible(number));
            Assert.Equal(print, _gameRuleNumberDivisibleByThreeAndFive.Print());
        }

        public static IEnumerable<object[]> DataMultiplesOfThreeAndFive() => Enumerable.Range(1, 100)
                                                                            .Where(n => n % 3 == 0 && n % 5 == 0)
                                                                            .Select(x => (new object[] { x, "FizzBuzz" }));


    }
}
