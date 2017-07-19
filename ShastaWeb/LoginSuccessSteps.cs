using System;
using TechTalk.SpecFlow;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace eSUBTests
{
    [Binding]
    public class LoginSuccessSteps: BaseSteps
    {
        [Given(@"I am on the eSUB login page")]
        public void GivenIAmOnTheESUBLoginPage()
        {
            NavigateTo("");
        }
        
        [When(@"I Enter with the following company Username")]
        public void WhenIEnterWithTheFollowingCompanyUsername(Table table)
        {
            driver.FindElement(By.Id("txtUsername")).SendKeys("Manager@esub.com");
            Thread.Sleep(1000);
        }
        
        [Then(@"I enter the correct Password")]
        public void ThenIEnterTheCorrectPassword(Table table)
        {
            driver.FindElement(By.Id("txtPassword")).SendKeys("Test1234");
            Thread.Sleep(1000);
        }
        
        [Then(@"I click on the Submit Button")]
        public void ThenIClickOnTheSubmitButton()
        {
            driver.FindElement(By.Id("btnLogin")).Click();
        }
        
        [Then(@"I should navigate to the Main Menu")]
        public void ThenIShouldNavigateToTheMainMenu()
        {
            NavigateTo("/#/project");
        }
    }
}
