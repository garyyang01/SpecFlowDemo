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

            return null;
        }
    }
}
