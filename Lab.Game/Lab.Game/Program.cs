using Lab.Game.FizzBuzz;
using System;
using System.Collections.Generic;

namespace Lab.Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var gameRules = new List<IGameRule>
            {
                new GameRuleNumberDivisibleByThreeAndFive(),
                new GameRuleNumberDivisibleByFive(),
                new GameRuleNumberDivisibleByThree()
            };

            GameService gameService = new GameService(gameRules);

            for(int i = 1; i < 25; i++)
            {
                Console.WriteLine(gameService.Print(i));
            }
            
            Console.ReadLine();
        }
    }
}
