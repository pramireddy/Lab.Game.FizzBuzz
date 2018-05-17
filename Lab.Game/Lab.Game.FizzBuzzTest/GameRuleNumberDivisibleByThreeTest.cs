using System.Linq;
using System.Collections.Generic;
using Lab.Game.FizzBuzz;
using Xunit;

namespace Lab.Game.FizzBuzzTest
{
    public class GameRuleNumberDivisibleByThreeTest
    {
        private GameRuleNumberDivisibleByThree _gameRuleNumberDivisibleByThree;

        public GameRuleNumberDivisibleByThreeTest()
        {
            _gameRuleNumberDivisibleByThree = new GameRuleNumberDivisibleByThree();
        }

        [Fact]
        public void IsDivisible_ShouldBe_False()
        {
            Assert.False(_gameRuleNumberDivisibleByThree.IsDivisible(2));
        }

        [Fact]
        public void IsDivisible_ShouldBe_True()
        {
            Assert.True(_gameRuleNumberDivisibleByThree.IsDivisible(6));
        }

        [Theory]
        [InlineData(2,false,"Fizz")]
        [InlineData(3,true,"Fizz")]
        [InlineData(6,true,"Fizz")]
        [InlineData(5,false,"Fizz")]
        [InlineData(10,false,"Fizz")]
        [InlineData(15,true,"Fizz")]
        public void Test_IsDivisible_And_Print(int number,bool IsDivisibleResult, string printResult)
        {
            Assert.Equal(IsDivisibleResult,_gameRuleNumberDivisibleByThree.IsDivisible(number));
            Assert.Equal(printResult, _gameRuleNumberDivisibleByThree.Print());
        }

        [Theory]
        [MemberData(nameof(DataMultiplesOfThree))]
        public void IsDivisible_ShouldBe_False_And_Print_ShouldBe_Fizz(int number, string print)
        {
            Assert.True(_gameRuleNumberDivisibleByThree.IsDivisible(number));
            Assert.Equal(print, _gameRuleNumberDivisibleByThree.Print());
        }

        public static IEnumerable<object[]> DataMultiplesOfThree() => Enumerable.Range(1, 25)
                                                                     .Where(n => n % 3 == 0 && n % 5 != 0)
                                                                     .Select(x => (new object[] { x, "Fizz" }));
    }
}
