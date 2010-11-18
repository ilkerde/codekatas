using System;

namespace KataTennis
{
    public class TennisGame
    {
        public Score[] scores = new Score[2];

        public TennisGame(Score scorePlayer1, Score scorePlayer2)
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
                return IsAnyScoreOverThreePoints() && IsScoreDifferenceAtLeastTwoPoints();
            }
        }

        private bool IsAnyScoreOverThreePoints()
        {
            return ((int)this.scores[0] > 3 || (int)this.scores[1] > 3);
        }

        private bool IsScoreDifferenceAtLeastTwoPoints()
        {
            return Math.Abs((int)this.scores[0] - (int)this.scores[1]) > 1;
        }
    }
}
