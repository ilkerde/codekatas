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

        public void GrantScoreTo(Player player)
        {
            this.scores[(int)player]++;
            this.UpdateScore(player);
        }

        private void UpdateScore(Player player)
        {
            int winPlayer = (int)player;
            int losePlayer = (int)this.GetOpponent(player);

            if (this.IsWinner(player))
            {
                this.scores[winPlayer] = Score.Game;
                this.scores[losePlayer] = Score.Love;
            }
        }

        public Score GetScoreOf(Player player)
        {
            return this.scores[(int)player];
        }

        public bool IsOver 
        {
            get
            {
                return IsAnyScoreOverThreePoints() && IsScoreDifferenceAtLeastTwoPoints();
            }
        }

        public bool IsWinner(Player player)
        {
            return this.IsOver && this.IsLeading(player);
        }

        private bool IsLeading(Player player)
        {
            int testForWinPlayer = (int)player;
            int opponentPlayer = (int)this.GetOpponent(player);

            return this.scores[testForWinPlayer] > this.scores[opponentPlayer];
        }

        private Player GetOpponent(Player player)
        {
            return (Player)(1 - (int)player);
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
