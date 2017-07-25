using System;
using TechTalk.SpecFlow;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;

namespace eSUBTests
{
    [Binding]
    public class FilterByEmployeeSteps: BaseSteps
    {
        [Given(@"a Project Manager is logged into Shasta,")]
        public void GivenAProjectManagerIsLoggedIntoShasta()
        {
            NavigateTo("/#/login");

            driver.FindElement(By.Id("txtUsername")).Clear();
            driver.FindElement(By.Id("txtUsername")).SendKeys("Manager@esub.com");

            Thread.Sleep(2000);

            driver.FindElement(By.Id("txtPassword")).Clear();
            driver.FindElement(By.Id("txtPassword")).SendKeys("Test1234");

            Thread.Sleep(2000);

            driver.FindElement(By.Id("btnLogin")).Click();
        }
        
        [When(@"the Project Manager Selects on the Time & Expense Dropdown Icon,")]
        public void WhenTheProjectManagerSelectsOnTheTimeExpenseDropdownIcon()
        { 
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//li[@id='time']/a/span/span")).Click();
            //driver.FindElement(By.Name("Group by"));

            Thread.Sleep(3000);
        }

        [Then(@"selects timesheets, the default filter is grouped by Employee and the timecards are displayed in full")]
        public void ThenSelectsTimesheetsTheDefaultFilterIsGroupedByEmployeeAndTheTimecardsAreDisplayedInFull()
        {
            driver.FindElement(By.XPath("//body[@id='body']/esub-root/div[2]/esub-app-home/esub-app-sidenav/nav/section[2]/esub-app-sidenav-menu/div/ul/li[4]/ul/li/a/span/span")).Click();

        }

        //public void ThenSelectsTimesheetsTheDefaultFilterIsGroupedByEmployee()
        //{
           // driver.FindElement(By.XPath("//body[@id='body']/esub-root/div[2]/esub-app-home/esub-app-sidenav/nav/section[2]/esub-app-sidenav-menu/div/ul/li[4]/ul/li/a/span/span")).Click();

       // }

       // [Then(@"the Timesheets view is displayed,")]
        //public void ThenTheTimesheetsViewIsDisplayed()
       // {
          //  ScenarioContext.Current.Pending();
        //}
        
       // [Then(@"the Timesheets view shall contain Timecards with hours associated with the selected Employee\.")]
       // public void ThenTheTimesheetsViewShallContainTimecardsWithHoursAssociatedWithTheSelectedEmployee_()
        //{
        //    ScenarioContext.Current.Pending();
        //}
    }
}
