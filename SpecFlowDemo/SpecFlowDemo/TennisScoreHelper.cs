using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemo
{
    public class TennisScoreHelper
    {
        public string GetDisplayScore(int playerAScore, int playerBScore)
        {
            if (playerAScore == 0 && playerBScore == 0)
            {
                return "Love All";
            }
            else if (playerAScore == 1 && playerBScore == 0) {
                return "Fifteen Love";
            }
            return null;
        }
    }
}
