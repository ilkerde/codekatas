using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataTennis
{
    public class TennisGame
    {
        public TennisGame(string score)
        {
        }

        public void Score(Player player)
        {
            this.IsOver = true;
        }
        
        public bool IsOver 
        { 
            get; 
            private set; 
        }
    }
}
