using System;
using System.Collections.Generic;

namespace Lab.Game.FizzBuzz
{
    public class GameService
    {
        private IList<IGameRule> _gameRules;

        public GameService(IList<IGameRule> gameRules) => _gameRules = gameRules;

        public string Print(int number)
        {
            foreach(IGameRule rule in _gameRules)
            {
                if (rule.IsDivisible(number))
                    return rule.Print();
            }
            return Convert.ToString(number);
        }
    }
}
