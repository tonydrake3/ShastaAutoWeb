using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace eSUBTests.Steps.Login
{
    [Binding]
    public class IncorrectPasswordSteps: BaseSteps
    {
        [Given(@"I am on the eSUB Sign In Page")]
        public void GivenIAmOnTheESUBSignInPage()
        {
            NavigateTo("");
            driver.WaitForElement("txtUsername");
        }
        
        [Given(@"I enter a correct UserName:")]
        public void GivenIEnterACorrectUserName(Table table)
        {
            driver.FindElement(By.Id("txtUsername")).Clear();
            driver.FindElement(By.Id("txtUsername")).SendKeys("Manager@esub.com");
        }
        
        [Given(@"I enter an incorrect Password:")]
        public void GivenIEnterAnIncorrectPassword(Table table)
        {
            driver.FindElement(By.Id("txtPassword")).Clear();
            driver.FindElement(By.Id("txtPassword")).SendKeys("t@st1234");
        }
        
        [Given(@"I click on Sign In")]
        public void GivenIClickOnSignIn()
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
