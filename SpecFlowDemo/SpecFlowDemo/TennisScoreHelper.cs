using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemo
{
    public static class TennisScoreHelper
    {
        public static string GetDisplayScore(int playerAScore, int playerBScore)
        {
            var displayScoreMapper=new List<String>(){"Love","Fifteen","Thirty","Forty"};
            if (playerAScore==0&&playerBScore==0)
            {
                return "Love All";
            }

            return $"{displayScoreMapper[playerAScore]} {displayScoreMapper[playerBScore]}";
            
        }
    }
}
