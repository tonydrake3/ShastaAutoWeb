using System;
using TechTalk.SpecFlow;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace eSUBTests.Steps.Login
{
    [Binding]
    public class InvalidthenValidLoginSteps: BaseSteps
    {
        [Given(@"a user navigates to the Login page at esub\.com")]
        public void GivenAUserNavigatesToTheLoginPageAtEsub_Com()
        {
            NavigateTo("");
        }
        
        [When(@"the User enters an invalid User Name or Password")]
        public void WhenTheUserEntersAnInvalidUserNameOrPassword()
        {
            driver.FindElement(By.Id("txtUsername")).Clear();
            driver.FindElement(By.Id("txtUsername")).SendKeys("Hawthorne@esub.com");
            driver.FindElement(By.Id("txtPassword")).Clear();
            driver.FindElement(By.Id("txtPassword")).SendKeys("Test1234");

            driver.WaitForElement("errorMessage");
        }
        
        [When(@"corrects the errors with a valid Email and Password")]
        public void WhenCorrectsTheErrorsWithAValidEmailAndPassword()
        {
            driver.FindElement(By.Id("txtUsername")).Clear();
            driver.FindElement(By.Id("txtUsername")).SendKeys("Manager@esub.com");
            driver.FindElement(By.Id("txtPassword")).Clear();
            driver.FindElement(By.Id("txtPassword")).SendKeys("Test1234");
        }
        
        [Then(@"the User shall be logged in")]
        public void ThenTheUserShallBeLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
