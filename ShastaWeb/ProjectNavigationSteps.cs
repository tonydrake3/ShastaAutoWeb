using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace eSUBTests
{
    [Binding]
    public class ProjectNavigationSteps : BaseSteps
    {
        [Given(@"a user has a selected project")]
        public void GivenAUserHasASelectedProject()
        {
            //Navigate to website
            NavigateTo("");

            //User lands on the Username Field
            driver.FindElement(By.Id("txtUsername")).Clear();
            
            //Enters email information
            driver.FindElement(By.Id("txtUsername")).SendKeys("Manager@esub.com");

            Thread.Sleep(1000);

            driver.FindElement(By.Id("txtPassword")).Clear();

            //User lands on the Password Field
            driver.FindElement(By.Id("txtPassword")).SendKeys("Test1234");

            Thread.Sleep(1000);
            
            // Click "Sign in"
            driver.FindElement(By.Id("btnLogin")).Click();

            Thread.Sleep(2000);
        
            NavigateTo("/#/project");
        }
        
        //[Given(@"a user has selected a project")]
       // public void GivenAUserHasSelectedAProject()
        //{
           // NavigateTo("/#/project");

       // }

        //[When(@"the Left Sidebar is displayed")]
        //public void WhenTheLeftSidebarIsDisplayed()
        //{
        //    ScenarioContext.Current.Pending();
       // }
        
        [When(@"the user clicks the Change Project menu item")]
        public void WhenTheUserClicksTheChangeProjectMenuItem()
        {
            driver.FindElement(By.XPath("//li[@id='select']/a/span/span")).Click();

        }

        [Then(@"the Left Sidebar shall contain a Change Project menu item")]
        public void ThenTheLeftSidebarShallContainAChangeProjectMenuItem()
        {
            driver.FindElement(By.XPath("//section[@id='page-container']/div/div/div/esub-project/ng-component/div/div[4]/esub-project-selection-card/div/div/div/div[2]/div[2]")).Click();

        }

        //[Then(@"the Change Project menu title shall change to Select Project")]
       // public void ThenTheChangeProjectMenuTitleShallChangeToSelectProject()
        //{
        //    ScenarioContext.Current.Pending();
       // }
        
        //[Then(@"the Select Project page shall be displayed")]
       // public void ThenTheSelectProjectPageShallBeDisplayed()
        //{
            //ScenarioContext.Current.Pending();
        //}
    }
}
