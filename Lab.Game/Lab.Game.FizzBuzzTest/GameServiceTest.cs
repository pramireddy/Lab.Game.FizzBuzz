using System.Collections.Generic;
using Lab.Game.FizzBuzz;
using Xunit;
using Moq;

namespace Lab.Game.FizzBuzzTest
{
    public class GameServiceTest
    {
        private Mock<IGameRule> _mockGameRule;
        private GameService _gameService;

        public GameServiceTest()
        {
            _mockGameRule = new Mock<IGameRule>();
        }

        [Fact]
        public void Print_ShouldBeNumber()
        {
            //arrange
            _mockGameRule.Setup(x => x.IsDivisible(It.IsAny<int>())).Returns(false);
            _gameService = new GameService(new List<IGameRule> { _mockGameRule.Object });

            //act
            var print = _gameService.Print(2);

            //assert
            Assert.Equal("2", print);
        }

        [Fact]
        public void Print_ShouldBeFizz()
        {
            //arrange
            _mockGameRule.Setup(x => x.IsDivisible(3)).Returns(true);
            _mockGameRule.Setup(x => x.Print()).Returns("Fizz");
            _gameService = new GameService(new List<IGameRule> { _mockGameRule.Object });

            //act
            var print = _gameService.Print(3);

            //assert
            Assert.Equal("Fizz", print);
        }

        [Fact]
        public void Print_ShouldBeBuzz()
        {
            //arrange
            _mockGameRule.Setup(x => x.IsDivisible(5)).Returns(true);
            _mockGameRule.Setup(x => x.Print()).Returns("Buzz");
            _gameService = new GameService(new List<IGameRule> { _mockGameRule.Object });

            //act
            var print = _gameService.Print(5);

            //assert
            Assert.Equal("Buzz", print);
        }

        [Fact]
        public void Print_ShouldBeFizzBuzz()
        {
            //arrange
            _mockGameRule.Setup(x => x.IsDivisible(15)).Returns(true);
            _mockGameRule.Setup(x => x.Print()).Returns("FizzBuzz");
            _gameService = new GameService(new List<IGameRule> { _mockGameRule.Object });

            //act
            var print = _gameService.Print(15);

            //assert
            Assert.Equal("FizzBuzz", print);
        }

    }
}
