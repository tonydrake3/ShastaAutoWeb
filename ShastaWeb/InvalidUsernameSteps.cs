using System;
using TechTalk.SpecFlow;

namespace eSUBTests
{
    [Binding]
    public class InvalidUsernameSteps
    {
        [Given(@"I have entered an incorrect username")]
        public void GivenIHaveEnteredAnIncorrectUsername(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered the correct password")]
        public void GivenIHaveEnteredTheCorrectPassword(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click Sign In")]
        public void WhenIClickSignIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should receive an error message")]
        public void ThenIShouldReceiveAnErrorMessage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
