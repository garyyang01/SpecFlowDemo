using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemo
{
    public static class TennisScoreHelper
    {
        public static string GetDisplayScore(int playerAScore, int playerBScore)
        {
            if (playerAScore==0&&playerBScore==0)
            {
                return "Love All";
            }
            if (playerAScore == 1 && playerBScore == 0)
            {
                return "Fifteen Love";
            }
            if (playerAScore == 2 && playerBScore == 0)
            {
                return "Thirty Love";
            }
            return null;
        }
    }
}
