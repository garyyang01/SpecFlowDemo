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
            var dominantPlayer = new List<string>(){ "Player A" ,"Player B"};
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
            if (playerAScore.Equals(3) && playerBScore.Equals(4))
            {
                return $"{dominantPlayer[1]} {matchStatus[0]}";
            }
            return $"{scoreMapper[playerAScore]} {scoreMapper[playerBScore]}";
            
        }
    }
}
