using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace eSUBTests.Steps.Projects.ProjectSummary
{
    [Binding]
    public class ProjectManagementMenuDropdownSteps: BaseSteps 
    {
        [Given(@"a user has a selected a company/account")]
        public void GivenAUserHasASelectedACompanyAccount()
        {
            NavigateTo("/#/login");

            Thread.Sleep(1000);

            driver.FindElement(By.Id("txtUsername")).Clear();
            driver.FindElement(By.Id("txtUsername")).SendKeys("Manager@esub.com");

            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtPassword")).Clear();
            driver.FindElement(By.Id("txtPassword")).SendKeys("Test1234");

            Thread.Sleep(1000);

            driver.FindElement(By.Id("btnLogin")).Click();

         }
        
        [When(@"the User selects a project")]
        public void WhenTheUserSelectsAProject()
        {
            Thread.Sleep(3000);

            driver.FindElement(By.CssSelector("project-card-16b2e5d9-59ba-4ce3-8821-b7fc7a86773a")).Click();
        }

        [Then(@"Shasta shall display the Project Management menu expanded in the left sidebar")]
        public void ThenShastaShallDisplayTheProjectManagementMenuExpandedInTheLeftSidebar()
        {
            ScenarioContext.Current.Pending();
        }
        
       // [Then(@"The Project summary shall display the following summary: '(.*)' '(.*)' '(.*)' '(.*)' '(.*)'")]
       // public void ThenTheProjectSummaryShallDisplayTheFollowingSummary(string p0, string p1, string p2, string p3, string p4)
        //{
        //    ScenarioContext.Current.Pending();
        //}
    }
}
