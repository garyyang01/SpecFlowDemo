﻿using System;
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
                return playerAScore>=3 ? "Deuce" : $"{displayScoreMapper[playerAScore]} All";
            }

            return $"{displayScoreMapper[playerAScore]} {displayScoreMapper[playerBScore]}";
            
        }
    }
}
