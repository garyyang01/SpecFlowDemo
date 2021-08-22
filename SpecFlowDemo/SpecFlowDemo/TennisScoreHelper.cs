using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemo
{
    public static class TennisScoreHelper
    {
        public static string GetDisplayScore(int playerAScore, int playerBScore)
        {
            var scoreMapper=new List<String>(){"Love","Fifteen","Thirty","Forty"};
            var dominantPlayer = new List<string>(){ "Player A" };
            var matchStatus = new List<string>() {"Adv", "Win"};
            if (playerAScore.Equals(playerBScore))
            {
                return playerAScore>=3 ? "Deuce" : $"{scoreMapper[playerAScore]} All";
            }
            if (playerAScore.Equals(4) && playerBScore.Equals(3))
            {
                return $"{dominantPlayer[0]} {matchStatus[0]}";
            }
            if (playerAScore.Equals(5) && playerBScore.Equals(3))
            {
                return $"{dominantPlayer[0]} {matchStatus[1]}";
            }
            return $"{scoreMapper[playerAScore]} {scoreMapper[playerBScore]}";
            
        }
    }
}
