using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace eSUBTests
{
    [Binding]
    public class IncorrectUserNameSteps: BaseSteps
    {
        
        [Given(@"when I am on the eSUB sign in page")]
        public void GivenWhenIAmOnTheESUBSignInPage()
        {
            NavigateTo("");
            driver.WaitForElement("txtUsername");
        }
        
        [When(@"I enter an incorrect username:")]
        public void WhenIEnterAnIncorrectUsername(Table table)
        {
            driver.FindElement(By.Id("txtUsername")).Clear();
            driver.FindElement(By.Id("txtUsername")).SendKeys("test@esub.com");
            
        }
        
        [When(@"I enter a correct Password:")]
        public void WhenIEnterACorrectPassword(Table table)
        {
            driver.FindElement(By.Id("txtPassword")).Clear();
            driver.FindElement(By.Id("txtPassword")).SendKeys("test1234");
            //Browser.Current
        }
        
        [Then(@"I click on Sign In")]
        public void ThenIClickOnSignIn()
        {
            driver.FindElement(By.Id("btnLogin")).Click();
        }
        
        [Then(@"I should receive an error message")]
        public void ThenIShouldReceiveAnErrorMessage()
        {
            driver.WaitForElement("errorMessage");
        }
    }
}
