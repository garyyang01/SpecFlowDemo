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
            if (playerAScore.Equals(playerBScore))
            {
                if (playerAScore>=3)
                {
                    return "Deuce";
                }

                return $"{displayScoreMapper[playerAScore]} All";
            }

            return $"{displayScoreMapper[playerAScore]} {displayScoreMapper[playerBScore]}";
            
        }
    }
}
