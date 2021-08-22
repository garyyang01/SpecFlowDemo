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
            if (playerAScore+playerBScore>6)
            {
                return
                    $"{dominantPlayer[(playerAScore > playerBScore) ? 0 : 1]} {matchStatus[Math.Abs(playerAScore - playerBScore) - 1]}";
            }
            return $"{scoreMapper[playerAScore]} {scoreMapper[playerBScore]}";
            
        }
    }
}
