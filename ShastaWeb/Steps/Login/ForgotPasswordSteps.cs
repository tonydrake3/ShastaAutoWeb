using System;
using TechTalk.SpecFlow;

namespace eSUBTests
{
    [Binding]
    public class ForgotPasswordSteps
    {
        [Given(@"I have entered the correct UserName")]
        public void GivenIHaveEnteredTheCorrectUserName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the link '(.*)'")]
        public void WhenIClickOnTheLink(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I forgot my password")]
        public void ThenIForgotMyPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will receive a message that will allow me to reset my password")]
        public void ThenIWillReceiveAMessageThatWillAllowMeToResetMyPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Once I reset my password")]
        public void ThenOnceIResetMyPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I navigate back to the sign in page")]
        public void ThenINavigateBackToTheSignInPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will re-enter my new password")]
        public void ThenIWillRe_EnterMyNewPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Successfully sign in to my account")]
        public void ThenSuccessfullySignInToMyAccount()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
