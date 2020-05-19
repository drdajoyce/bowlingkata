using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingKata
{
    public class Game
    {
        int _score = 0;

        public void Roll(int pins)
        {
            _score += pins;
        }

        public int Score()
        {
            return _score;
        }
    }
}
