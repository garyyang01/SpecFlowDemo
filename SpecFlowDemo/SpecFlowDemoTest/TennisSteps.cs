using System;
using FluentAssertions;
using NUnit.Framework;
using SpecFlowDemo;
using TechTalk.SpecFlow;

namespace SpecFlowDemoTest
{
    [Binding]
    public class TennisSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private const string DisplayScore = "DisplayScore";
        private const string PlayerAScoreKey = "PlayerAScore";
        private const string PlayerBScoreKey = "PlayerBScore";

        public TennisSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"playerA (.*) and playerB (.*)")]
        public void GivenPlayerAAndPlayerB(int playerAScore, int playerBScore)
        {
            _scenarioContext.Set(playerAScore,PlayerAScoreKey);
            _scenarioContext.Set(playerBScore,PlayerBScoreKey);
        }

        [When(@"Get display score")]
        public void WhenGetDisplayScore()
        {
            var playerAScore = _scenarioContext.Get<int>(PlayerAScoreKey);
            var playerBScore = _scenarioContext.Get<int>( PlayerBScoreKey);

            _scenarioContext.Set(TennisScoreHelper.GetDisplayScore(playerAScore, playerBScore), DisplayScore);
        }
        
        [Then(@"the display score should be ""(.*)""")]
        public void ThenTheDisplayScoreShouldBe(string expectedDisplayScore)
        {
            var calDisplayScore = _scenarioContext.Get<string>(DisplayScore);
            expectedDisplayScore.Should().Be(calDisplayScore);
        }
    }
}
