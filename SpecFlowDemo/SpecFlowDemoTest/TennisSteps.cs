using NUnit.Framework;
using SpecFlowDemo;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowDemoTest
{
    [Binding]
    public class TennisSteps
    {
        private readonly ScenarioContext scenarioContext;

        public TennisSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }
        [Given(@"playerA (.*) and playerB (.*)")]
        public void GivenPlayerAAndPlayerB(int playerAScore, int playerBScore)
        {
            scenarioContext.Set<int>(playerAScore, "playerAScore");
            scenarioContext.Set<int>(playerBScore, "playerBScore");
        }
        
        [When(@"Get display score")]
        public void WhenGetDisplayScore()
        {
            var playerAScore = scenarioContext.Get<int>("playerAScore");
            var playerBScore = scenarioContext.Get<int>("playerBScore");

            TennisScoreHelper helper = new TennisScoreHelper();
            var result = helper.GetDisplayScore(playerAScore, playerBScore);

            scenarioContext.Set<string>(result, "result");
        }
        
        [Then(@"the display score should be (.*)")]
        public void ThenTheDisplayScoreShouldBe(string expected)
        {
            var result = scenarioContext.Get<string>("result");

            Assert.AreEqual(expected, result);
        }
    }
}
