using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using System.Threading;

namespace eSUBTests.Steps.Projects.Filter_By
{
    [Binding]
    public class ProjectNavigationSteps : BaseSteps
    {
        [Given(@"the user has selected a project, the side menu should display the text '(.*)'")]
        public void GivenTheUserHasSelectedAProjectTheSideMenuShouldDisplayTheText(string p0)
        {
            NavigateTo("");

            driver.FindElement(By.Id("txtUsername")).Clear();
            driver.FindElement(By.Id("txtUsername")).SendKeys("Manager@esub.com");

            Thread.Sleep(2000);

            driver.FindElement(By.Id("txtPassword")).Clear();
            driver.FindElement(By.Id("txtPassword")).SendKeys("Test1234");

            Thread.Sleep(1000);

            driver.FindElement(By.Id("btnLogin")).Click();
        }
        
        [Then(@"the user clicks on '(.*)' and the text '(.*)' should display")]
        public void ThenTheUserClicksOnAndTheTextShouldDisplay(string p0, string p1)
        {
            Thread.Sleep(1000);

            driver.FindElement(By.CssSelector("#project-card-125957a9-b5f9-4e12-a292-b0551c4a7165 > div.row > div.col-md-6.project-location")).Click();

            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//li[@id='select']/a/span/span")).Click();

        }
    }
}
