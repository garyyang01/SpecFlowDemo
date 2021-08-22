using System;
using TechTalk.SpecFlow;

namespace SpecFlowDemoTest
{
    [Binding]
    public class TennisSteps
    {
        private ScenarioContext _scenarioContext;
        public TennisSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"playerA (.*) and playerB (.*)")]
        public void GivenPlayerAAndPlayerB(int playerAScore, int playerBScore)
        {
            _scenarioContext.Pending();
        }
        
        [When(@"Get display score")]
        public void WhenGetDisplayScore()
        {
            _scenarioContext.Pending();
        }
        
        [Then(@"the display score should be ""(.*)""")]
        public void ThenTheDisplayScoreShouldBe(string displayScore)
        {
            _scenarioContext.Pending();
        }
    }
}
