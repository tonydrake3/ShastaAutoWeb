using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace eSUBTests.Steps.Login
{
    [Binding]
    public class LoginSteps: BaseSteps
    {
        [Given(@"I am on the eSUB sign in page")]
        public void GivenIAmOnTheESUBSignInPage()
        {
            NavigateTo("");
            driver.WaitForElement("txtUsername");
        }

        [Given(@"I login with the following user:")]
        public void GivenILoginWithTheFollowingUser(Table table)
        {
            driver.FindElement(By.Id("txtUsername")).Clear();
            driver.FindElement(By.Id("txtUsername")).SendKeys("Test1234");

            Thread.Sleep(1000);

            driver.FindElement(By.Id("txtPassword")).Clear();
            driver.FindElement(By.Id("txtPassword")).SendKeys("1234567");
        }

        [Given(@"I click the '(.*)' Button")]
        public void GivenIClickTheButton(string p0)
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
