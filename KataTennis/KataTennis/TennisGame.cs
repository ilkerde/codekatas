using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataTennis
{
    public class TennisGame
    {
        public int[] scores = new int[2];

        public TennisGame(int scorePlayer1, int scorePlayer2)
        {
            this.scores[0] = scorePlayer1;
            this.scores[1] = scorePlayer2;
        }

        public void Score(Player player)
        {
            this.scores[(int)player]++;
        }
        
        public bool IsOver 
        {
            get
            {
                return this.scores[0] > 3 || this.scores[1] > 3;
            }
        }
    }
}
