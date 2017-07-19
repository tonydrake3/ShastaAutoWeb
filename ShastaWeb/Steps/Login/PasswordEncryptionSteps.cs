using System;
using TechTalk.SpecFlow;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace eSUBTests.Steps.Login
{
    [Binding]
    public class PasswordEncryptionSteps: BaseSteps
    {
        [Given(@"I am on the eSUB Login Page")]
        public void GivenIAmOnTheESUBLoginPage()
        {
            NavigateTo(""); 
        }
        
        [When(@"I login with the following company Username")]
        public void WhenILoginWithTheFollowingCompanyUsername(Table table)
        {
            driver.FindElement(By.Id("txtUsername")).SendKeys("Manager@esub.com");
            Thread.Sleep(1000);

        }
        
        [Then(@"I enter any password")]
        public void ThenIEnterAnyPassword(Table table)
        {
            driver.FindElement(By.Id("txtPassword")).SendKeys("Test1234");
            Thread.Sleep(1000);
        }
        
        [Then(@"I should see Encrypting characters immediately striking each key when I enter my password")]
        public void ThenIShouldSeeEncryptingCharactersImmediatelyStrikingEachKeyWhenIEnterMyPassword()
        {
           ScenarioContext.Current.Pending();
        }
    }
}
