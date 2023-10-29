using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class Score
    {
        public int ScoreSnake { get; set; }

        public Score()
        {
            ScoreSnake = 0;
        }

        public void IncreaseScore(int dots)
        {
            ScoreSnake += dots;
        }

        public void DisplayScore()
        {
            Console.SetCursorPosition(35, 15);
            Console.Write("Score: " + ScoreSnake);
        }
    }
}
